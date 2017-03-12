using NoruST.Analyses;
using NoruST.Models;

namespace NoruST.Forms
{
    /// <summary>
    /// <para>Runs Test for Randomness Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Thomas Van Rompaey</para>
    /// <para>Edited by: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 24, 2016</para>
    /// </summary>
    public partial class RunsTestForRandomnessForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="RunsTestForRandomnessForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public RunsTestForRandomnessForm()
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
            return new RunsTestForRandomness().Print(SelectedDataSet, DoInclude, new SummaryStatisticsBool(rdbMeanOfData.Checked, median: rdbMedianOfData.Checked, customCutoffValue: rdbCustomCutoffValue.Checked), txtCustomCutoffValue.Text);
        }

        #endregion
    }
}