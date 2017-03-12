using NoruST.Analyses;

namespace NoruST.Forms
{
    /// <summary>
    /// <para>The Histogram Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 23, 2016</para>
    /// </summary>
    public partial class HistogramForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="HistogramForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public HistogramForm()
        {
            InitializeComponent();

            InitializeView(lstDataSets, chkPerCategorie, dgvDataSet, chkCheckAllOptions, tlpOptions, btnOk, btnCancel);
        }

        #endregion

        #region Interaction Methods

        /// <summary>
        /// Fired when the <see cref="System.Windows.Forms.NumericUpDown.Value"/> for the name <see cref="System.Windows.Forms.NumericUpDown"/> changes.
        /// </summary>
        private void nudNumberOfBins_ValueChanged(object sender, System.EventArgs e)
        {
            chkNumberOfBins.Checked = true;
        }

        #endregion

        #region Overwritten Methods

        /// <summary>
        /// This adds extra functionality to the DataSet<see cref="System.Windows.Forms.ListBox"/>.
        /// </summary>
        public override void DataSetListSelectedIndexChanged()
        {
            // Create a data table and add the required columns.
            CreateDataTable(DataTableColumn.Editable);

            // Update the view with new data.
            UpdateDataTable(DefaultCheck.Numeric);
        }

        /// <summary>
        /// This adds extra functionality to the Ok <see cref="System.Windows.Forms.Button"/>
        /// </summary>
        public override bool OkButtonClick()
        {
            return chkPerCategorie.Checked ? new Histogram().CreateChart(SelectedDataSet, DoIncludeX, DoIncludeY, chkNumberOfBins.Checked, (int)nudNumberOfBins.Value) : new Histogram().CreateChart(SelectedDataSet, DoInclude, chkNumberOfBins.Checked, (int)nudNumberOfBins.Value);
        }

        #endregion
    }
}