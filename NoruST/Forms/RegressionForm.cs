using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoruST.Analyses;
using NoruST.Domain;
using NoruST.Models;
using NoruST.Presenters;
using DataSet = NoruST.Domain.DataSet;

namespace NoruST.Forms
{
    public partial class RegressionForm : Form
    {
        private RegressionPresenter presenter;

        public RegressionForm()
        {
            InitializeComponent();
        }

        public void setPresenter(RegressionPresenter presenter)
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
                uiDataGridViewColumn_VariableCheckX.Width = 20;
                uiDataGridViewColumn_VariableCheckY.Width = 20;
                uiDataGridView_Variables.Columns[2].ReadOnly = true;
                uiDataGridView_Variables.Columns[3].ReadOnly = true;
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
            List<Variable> independentVariables = new List<Variable>();
            List<Variable> dependentVariables = new List<Variable>();
            foreach (DataGridViewRow row in uiDataGridView_Variables.Rows)
            {
                if (Convert.ToBoolean(row.Cells[uiDataGridViewColumn_VariableCheckX.Name].Value))
                {
                    independentVariables.Add((Variable)row.DataBoundItem);
                }
                if (Convert.ToBoolean(row.Cells[uiDataGridViewColumn_VariableCheckY.Name].Value))
                {
                    dependentVariables.Add((Variable)row.DataBoundItem);
                }
            }
            if (dependentVariables.Count != 1)
            {
                MessageBox.Show("Please select exactly 1 dependent variable", "Regression error");
                return;
            }
            if (independentVariables.Contains(dependentVariables[0]))
            {
                MessageBox.Show("The dependent variable can not be an independent variable.", "Regression error");
                return;
            }
            if (independentVariables.Count < 1)
            {
                MessageBox.Show("Please select at least 1 independent variable", "Regression error");
                return;
            }

            presenter.getModel().fittedVSActual = chkFittedValuesVsActualYValues.Checked;
            presenter.getModel().residualsVSFitted = chkResidualsVsFittedValues.Checked;
            presenter.getModel().residualsVSX = chkResidualsVsXValues.Checked;
            presenter.getModel().regressionEquation = chkDisplayRegressionEquation.Checked;
            presenter.getModel().confidenceLevel = (double)nudConfidenceLevel.Value / 100.0;

            presenter.createRegression(selectedDataSet(), independentVariables, dependentVariables[0]);
            Close();
            Globals.ExcelAddIn.Application.ActiveWindow.Activate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Globals.ExcelAddIn.Application.ActiveWindow.Activate();
        }
    }
}