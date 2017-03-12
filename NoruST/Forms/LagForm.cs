using NoruST.Data;

namespace NoruST.Forms
{
    /// <summary>
    /// <para>The Lag Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 14, 2016</para>
    /// </summary>
    public partial class LagForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="LagForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public LagForm()
        {
            InitializeComponent();

            InitializeView(lstDataSets, dgvDataSet, btnOk, btnCancel);
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
            return new DummyLag().AddLag(SelectedDataSet, DoInclude, (int)nudLag.Value);
        }

        #endregion
    }
}