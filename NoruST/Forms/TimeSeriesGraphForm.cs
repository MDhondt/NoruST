using System.Collections.Generic;
using NoruST.Analyses;

// ReSharper disable LoopCanBeConvertedToQuery

namespace NoruST.Forms
{
    /// <summary>
    /// <para>Time Series Graph Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Thomas Van Rompaey</para>
    /// <para>Edited by: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: May 05, 2016</para>
    /// </summary>
    public partial class TimeSeriesGraphForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="TimeSeriesGraphForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public TimeSeriesGraphForm()
        {
            InitializeComponent();

            InitializeView(lstDataSets, dgvDataSet, chkCheckAllOptions, tlpOptions, btnOk, btnCancel);
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

            // Update the Labels ComboBox with the names of the data in the selected DataSet.
            cbxLabels.DataSource = null;
            var labels = new List<string>();
            foreach (var data in SelectedDataSet.DataList)
                labels.Add(data.Name);
            cbxLabels.DataSource = labels;
        }

        /// <summary>
        /// This adds extra functionality to the Ok <see cref="System.Windows.Forms.Button"/>
        /// </summary>
        public override bool OkButtonClick()
        {
            return new TimeSeriesGraph().CreateGraph(SelectedDataSet, DoInclude, chkLabels.Checked, cbxLabels.SelectedIndex);
        }

        #endregion
    }
}