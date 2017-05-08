using System;
using System.Windows.Forms;
using NoruST.Forms;
using NoruST.Presenters;
using NoruST.Domain;
using System.Collections.Generic;

namespace NoruST.Forms
{
    public partial class TimeSeriesGraphForm : Form
    {
        private TimeSeriesGraphPresenter presenter;
        private const string formTitle = "NoruST - Time Series Graph";

        public TimeSeriesGraphForm()
        {
            InitializeComponent();

        }

        public void setPresenter(TimeSeriesGraphPresenter TimeSeriesGraphPresenter)
        {
            this.presenter = TimeSeriesGraphPresenter;
            bindModelToView();
            selectDataSet(selectedDataSet());
        }

        private void bindModelToView()
        {
            ui_ComboBox_SelectDataSets.DataSource = presenter.dataSets();
            ui_ComboBox_SelectDataSets.DisplayMember = "name";
            ui_ComboBox_SelectDataSets.SelectedIndexChanged += (obj, eventArgs) =>
            {
                if (selectedDataSet() == null) return;
                dataGridView1.DataSource = selectedDataSet().getVariables();
                uiDataGridViewColumn_Checked.Width = 30;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
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
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton_Ok_Click(object sender, EventArgs e)
        {
            List<Variable> variables = new List<Variable>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[uiDataGridViewColumn_Checked.Name].Value) == true)
                {
                    variables.Add((Variable)row.DataBoundItem);
                }
            }

            bool inputOk = presenter.checkInput(variables, selectedDataSet(), rdbPlotAllObservations.Checked, rdbPlotOnlyObservationsWithin.Checked, uiTextbox_PlotStartIndex.Text, uiTextbox_PlotStopIndex.Text);
            if (inputOk)
            {
                Close();
            }
        }

        private void rdbPlotAllObservations_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbPlotOnlyObservationsWithin_CheckedChanged(object sender, EventArgs e)
        {
            lblPlotStartIndex.Visible = rdbPlotOnlyObservationsWithin.Checked;
            lblPlotStopIndex.Visible = rdbPlotOnlyObservationsWithin.Checked;
            uiTextbox_PlotStartIndex.Visible = rdbPlotOnlyObservationsWithin.Checked;
            uiTextbox_PlotStopIndex.Visible = rdbPlotOnlyObservationsWithin.Checked;
            uiTextbox_PlotStopIndex.Text = "0";
            uiTextbox_PlotStartIndex.Text = "0";
        }

    } 
}

