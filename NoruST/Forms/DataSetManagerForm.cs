using System;
using System.Windows.Forms;
using NoruST.Data;

namespace NoruST.Forms
{
    /// <summary>
    /// <para>DataSet Manager Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 16, 2016</para>
    /// </summary>
    public partial class DataSetManagerForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="DataSetManagerForm"/> <see cref="Form"/>.
        /// </summary>
        public DataSetManagerForm()
        {
            InitializeComponent();

            InitializeView(lstDataSets, dgvDataSet, null, btnClose, true);
        }

        #endregion

        #region Interaction Methods

        /// <summary>
        /// Fired when the New <see cref="Button"/> is pressed.
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Create a new DataSet.
            DataSetManager.NewDataSet();
        }

        /// <summary>
        /// Fired when the Delete <see cref="Button"/> is pressed.
        /// </summary>
        private void btnDeleteDataSet_Click(object sender, EventArgs e)
        {
            // Remove the selected DataSet from the List.
            SelectedDataSet.RemoveNamedRanges();
            Globals.ThisAddIn.DataSets.Remove(SelectedDataSet);

            // Reload the DataSource and update the view based on how many DataSets are in the List.
            lstDataSets.DataSource = null;
            lstDataSets.DataSource = Globals.ThisAddIn.DataSets;
            if (Globals.ThisAddIn.DataSets.Count > 0)
                lstDataSets.SelectedIndex = 0;
            else
            {
                RemoveEventHandlers();
                txtName.Text = "";
                rdbColumns.Checked = true;
                chkHasHeaders.Checked = true;
                dgvDataSet.DataSource = null;
                AddEventHandlers();
            }
        }

        /// <summary>
        /// Fired when the <see cref="TextBox.Text"/> for the name <see cref="TextBox"/> value changes.
        /// </summary>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // If the selected DataSet is not null, update its name with the new one.
            if (SelectedDataSet != null)
                SelectedDataSet.Name = txtName.Text;
        }

        /// <summary>
        /// Fired when the <see cref="CheckBox.Checked"/> for the header <see cref="CheckBox"/> changes from true to false or vice versa.
        /// </summary>
        private void chkHasHeaders_CheckedChanged(object sender, EventArgs e)
        {
            // Update the list of data so the changes take effect.
            if (SelectedDataSet.FirstIsName != chkHasHeaders.Checked)
                SelectedDataSet.UpdateDataList(SelectedDataSet.Layout, chkHasHeaders.Checked);

            // Make the first column editable if the check box isn't checked and vice versa.
            SetColumnReadOnly(ColVarName, chkHasHeaders.Checked);

            // Update the view with new data.
            UpdateDataTable();
        }

        /// <summary>
        /// Fired when the <see cref="RadioButton.Checked"/> for either the column and row <see cref="RadioButton"/> changes from true to false or vice versa.
        /// </summary>
        private void rdbColumns_rdbRows_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the sender is a RadioButton, not null and checked.
            var rb = sender as RadioButton;
            if (rb != null && !rb.Checked) return;

            // Update the DataList with the new arguments.
            SelectedDataSet.UpdateDataList(rdbColumns.Checked ? NoruST.Layout.Columns : NoruST.Layout.Rows, SelectedDataSet.FirstIsName);

            // Update the view with new data.
            UpdateDataTable();
        }

        /// <summary>
        /// Fired when a value in a <see cref="DataGridViewCell"/> for the visualization of the DataSet <see cref="DataGridView"/> changes.
        /// </summary>
        private void dgvDataSet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verify that each cell value is not null or an empty string.
            for (var row = 0; row < dgvDataSet.Rows.Count; row++)
                if (dgvDataSet.Rows[row].Cells[ColVarName].Value != null && dgvDataSet.Rows[row].Cells[ColVarName].Value.ToString().Length != 0)
                    // Only the Variable Name column is editable so this is the one that needs to be updated.
                    SelectedDataSet.DataList[row].SetName(dgvDataSet.Rows[row].Cells[ColVarName].Value.ToString());

            // Update the view with new data.
            UpdateDataTable();
        }

        /// <summary>
        /// Fired when the Undo <see cref="Button"/> is pressed.
        /// </summary>
        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Save the current SelectedIndex.
            var selectedIndex = lstDataSets.SelectedIndex;

            // Reload the DataSource from the backup.
            lstDataSets.DataSource = null;
            foreach (var dataSet in Globals.ThisAddIn.DataSets)
                dataSet.RemoveNamedRanges();
            Globals.ThisAddIn.DataSets.Clear();
            foreach (var dataSet in BackupDataSet)
                Globals.ThisAddIn.DataSets.Add(dataSet.DeepClone());
            lstDataSets.DataSource = Globals.ThisAddIn.DataSets;

            // Set the SelectedIndex back to the saved one if possible.
            if (BackupDataSet.Count >= selectedIndex)
                lstDataSets.SelectedIndex = selectedIndex != -1 ? selectedIndex : 0;
        }

        #endregion

        #region Overwritten Methods

        /// <summary>
        /// This adds extra functionality to the DataSet<see cref="ListBox"/>.
        /// </summary>
        public override void DataSetListSelectedIndexChanged()
        {
            // Set the DataSet name in the TextBox.
            txtName.Text = SelectedDataSet.Name;

            // Create a data table and add the required columns.
            CreateDataTable(varName: SelectedDataSet.FirstIsName ? DataTableColumn.ReadOnly : DataTableColumn.Editable);

            // Update the view so it represents the content of the selected DataSet. Therefore EventHandlers have to ne first removed and added back afterwards to prevent Event chaining.
            RemoveEventHandlers();
            chkHasHeaders.Checked = SelectedDataSet.FirstIsName;
            if (SelectedDataSet.Layout == NoruST.Layout.Columns)
                rdbColumns.Checked = true;
            else
                rdbRows.Checked = true;
            AddEventHandlers();

            // Update the view with new data.
            UpdateDataTable();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Remove EventHandlers.
        /// </summary>
        private void RemoveEventHandlers()
        {
            chkHasHeaders.CheckedChanged -= chkHasHeaders_CheckedChanged;
            rdbColumns.CheckedChanged -= rdbColumns_rdbRows_CheckedChanged;
            rdbRows.CheckedChanged -= rdbColumns_rdbRows_CheckedChanged;
        }

        /// <summary>
        /// Add EventHandlers.
        /// </summary>
        private void AddEventHandlers()
        {
            chkHasHeaders.CheckedChanged += chkHasHeaders_CheckedChanged;
            rdbColumns.CheckedChanged += rdbColumns_rdbRows_CheckedChanged;
            rdbRows.CheckedChanged += rdbColumns_rdbRows_CheckedChanged;
        }

        #endregion

        #region Properties

        public DataSetManager DataSetManager { get; set; }

        #endregion
    }
}