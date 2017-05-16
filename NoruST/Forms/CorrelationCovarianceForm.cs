using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoruST.Domain;
using NoruST.Presenters;

namespace NoruST.Forms
{
    public partial class CorrelationCovarianceForm : Form
    {
        private CorrelationCovariancePresenter presenter;

        public CorrelationCovarianceForm()
        {
            InitializeComponent();
        }

        public void setPresenter(CorrelationCovariancePresenter presenter)
        {
            this.presenter = presenter;
            bindModelToView();
            selectDataSet(selectedDataSet());
        }

        private void bindModelToView()
        {
            uiComboBox_DataSets.DataSource = presenter.dataSets();
            uiComboBox_DataSets.DisplayMember = "name";
            uiComboBox_DataSets.SelectedIndexChanged += (obj, eventArgs) =>
            {
                if (selectedDataSet() == null) return;
                uiDataGridView_Variables.DataSource = selectedDataSet().getVariables();
                uiDataGridViewColumn_VariableCheck.Width = 30;
                uiDataGridView_Variables.Columns[1].ReadOnly = true;
                uiDataGridView_Variables.Columns[2].ReadOnly = true;
            };
        }

        private DataSet selectedDataSet()
        {
            return uiComboBox_DataSets.SelectedItem as DataSet;
        }

        public void selectDataSet(DataSet dataSet)
        {
            uiComboBox_DataSets.SelectedItem = null;
            uiComboBox_DataSets.SelectedItem = dataSet;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Variable> variables = new List<Variable>();
            foreach (DataGridViewRow row in uiDataGridView_Variables.Rows)
            {
                if (Convert.ToBoolean(row.Cells[uiDataGridViewColumn_VariableCheck.Name].Value))
                {
                    variables.Add((Variable)row.DataBoundItem);
                }
            }

            presenter.createCorrelationCovariance(variables, checkBox1.Checked, checkBox2.Checked);
            Close();
            Globals.ExcelAddIn.Application.ActiveWindow.Activate();
        }

        private void uiButton_Cancel_Click(object sender, EventArgs e)
        {
            Close();
            Globals.ExcelAddIn.Application.ActiveWindow.Activate();
        }
    }
}