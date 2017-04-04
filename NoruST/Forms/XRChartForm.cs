using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoruST.Forms;
using NoruST.Presenters;
using NoruST.Domain;
using static System.Windows.Forms.DialogResult;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

namespace NoruST.Forms
{
    public partial class XRChartForm : Form
    {
        private XRChartPresenter presenter;
        private const string formTitle = "NoruST - XRChart";

        public XRChartForm()
        {
            InitializeComponent();

        }

        public void setPresenter(XRChartPresenter XRChartPresenter)
        {
            this.presenter = XRChartPresenter;
            bindModelToView();
            selectDataSet(selectedDataSet());
        }

        private void bindModelToView()
        {
            ui_ComboBox_SelectDataSets.DataSource = presenter.dataSets();
            ui_ComboBox_SelectDataSets.DisplayMember = "name";
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            ui_ComboBox_SelectDataSets.SelectedIndexChanged += (obj, eventArgs) =>
            {
                if (selectedDataSet() == null) return;
                dataGridView1.DataSource = selectedDataSet().getVariables();
            };
        }

        private DataSet selectedDataSet()
        {
            return (DataSet)ui_ComboBox_SelectDataSets.SelectedItem;
        }

        public void selectDataSet(DataSet dataSet)
        {
            ui_ComboBox_SelectDataSets.SelectedItem = null;
            ui_ComboBox_SelectDataSets.SelectedItem = dataSet;
        }

        private void Cancelbutton_clicked(object sender, EventArgs e)
        {
            Close();
            presenter.checkInput(Rchart.Checked, Xbar.Checked, rdbAllObservations.Checked, rdbObservationsInRange.Checked, rdbPreviousData.Checked, selectedDataSet());
        }

        private void ObservationsInRange_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox_StartIndex.Visible = rdbObservationsInRange.Checked;
            uiTextBox_StopIndex.Visible = rdbObservationsInRange.Checked;
            lblStartIndex.Visible = rdbObservationsInRange.Checked;
            lblStopIndex.Visible = rdbObservationsInRange.Checked;
        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            
        }

    }
}

