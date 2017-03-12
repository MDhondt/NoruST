using NoruST.Analyses;
using NoruST.Models;

namespace NoruST.Forms
{
    /// <summary>
    /// <para>The One-Variable Summary Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 20, 2016</para>
    /// </summary>
    public partial class ConfidenceIntervalMeanAndStandardDeviationForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="OneVariableSummaryForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public ConfidenceIntervalMeanAndStandardDeviationForm()
        {
            InitializeComponent();

            InitializeView(lstDataSets, chkPerCategorie, dgvDataSet, chkCheckAllOptions, tlpOptions, btnOk, btnCancel);
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
            var doCalculate = new SummaryStatisticsBool(meanConfidenceInterval: chkMean.Checked, standardDeviationConfidenceInterval: chkStandardDeviation.Checked);

            return chkPerCategorie.Checked ? new OneVariableSummary().Print(SelectedDataSet, DoIncludeX, DoIncludeY, doCalculate, (int)nudMean.Value, (int)nudStandardDeviation.Value, sheetName: "Confidence Interval") : new OneVariableSummary().Print(SelectedDataSet, DoInclude, doCalculate, (int)nudMean.Value, (int)nudStandardDeviation.Value, sheetName: "Confidence Interval");
        }

        #endregion
    }
}