using NoruST.Analyses;

namespace NoruST.Forms
{
    /// <summary>
    /// <para>Scatterplot Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 17, 2016</para>
    /// </summary>
    public partial class ScatterplotForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="ScatterplotForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public ScatterplotForm()
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
            CreateDataTable(xy: DataTableColumn.Editable);

            // Update the view with new data.
            UpdateDataTable(checkX: DefaultCheck.Numeric, checkY: DefaultCheck.Numeric);
        }

        /// <summary>
        /// This adds extra functionality to the Ok <see cref="System.Windows.Forms.Button"/>
        /// </summary>
        public override bool OkButtonClick()
        {
            return new Scatterplot().CreateChart(SelectedDataSet, DoIncludeX, DoIncludeY);
        }

        #endregion
    }
}