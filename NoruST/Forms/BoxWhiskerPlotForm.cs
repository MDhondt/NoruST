using NoruST.Analyses;

namespace NoruST.Forms
{
    /// <summary>
    /// <para>The Box - Whisker Plot Form.</para>
    /// <para>Version: 3.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 18, 2016</para>
    /// </summary>
    public partial class BoxWhiskerPlotForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="BoxWhiskerPlotForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public BoxWhiskerPlotForm()
        {
            InitializeComponent();

            InitializeView(lstDataSets, chkPerCategorie, dgvDataSet, btnOk, btnCancel);
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
        /// This adds extra functionality to the Ok<see cref="System.Windows.Forms.Button"/>.
        /// </summary>
        public override bool OkButtonClick()
        {
            return chkPerCategorie.Checked ? new BoxWhiskerPlot().CreateChart(SelectedDataSet, DoIncludeX, DoIncludeY) : new BoxWhiskerPlot().CreateChart(SelectedDataSet, DoInclude);
        }

        #endregion
    }
}