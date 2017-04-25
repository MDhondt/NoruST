using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoruST.Presenters;
using NoruST.Domain;

namespace NoruST.Forms
{
    public partial class PChartForm : Form
    {

        private PChartPresenter presenter;

        public void setPresenter(PChartPresenter PChartPresenter)
        {
            this.presenter = PChartPresenter;
            bindModelToView();
            selectDataSet(selectedDataSet());
        }

        public void selectDataSet(DataSet dataSet)
        {
            ui_ComboBox_SelectDataSets.SelectedItem = null;
            ui_ComboBox_SelectDataSets.SelectedItem = dataSet;
        }

        private DataSet selectedDataSet()
        {
            return (DataSet)ui_ComboBox_SelectDataSets.SelectedItem;
        }

        public PChartForm()
        {
            InitializeComponent();
        }

        private void ui_Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton_Ok_Click(object sender, EventArgs e)
        {
            bool inputOk = presenter.checkInput(ui_RadioButton_AllObservations.Checked, ui_RadioButton_ObservationsInRange.Checked, ui_RadioButton_PreviousData.Checked, selectedDataSet(), ui_TextBox_StopIndex.Text, ui_TextBox_StartIndex.Text);
            if (inputOk)
            {
                Close();
            }
        }

        private void RB_Observationsinrange_CheckedChanged(object sender, EventArgs e)
        {
            ui_TextBox_StartIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
            ui_TextBox_StopIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
            lblStartIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
            lblStopIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
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
    }
}
