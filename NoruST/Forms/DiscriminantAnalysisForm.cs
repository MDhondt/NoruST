﻿using NoruST.Analyses;
using System.Collections.Generic;
using System.Windows.Forms;
using NoruST.Presenters;
using NoruST.Domain;
using System;

namespace NoruST.Forms
{

    public partial class DiscriminantAnalysisForm : Form
    {

        private DiscriminantAnalysisPresenter presenter;
        private const string formTitle = "NoruST - Discriminant Analysis";

        public DiscriminantAnalysisForm()
        {
            InitializeComponent();
        }


        public void setPresenter(DiscriminantAnalysisPresenter DiscriminantAnalysisPresenter)
        {
            this.presenter = DiscriminantAnalysisPresenter;
            bindModelToView();
            selectDataSet(selectedDataSet());
        }

        private void bindModelToView()
        {
            lstDataSets.DataSource = presenter.dataSets();
            lstDataSets.DisplayMember = "name";
            //nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            //rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            lstDataSets.SelectedIndexChanged += (obj, eventArgs) =>
            {
                if (selectedDataSet() == null) return;
                dgvDataSet.DataSource = selectedDataSet().getVariables();
            };
        }

        private DataSet selectedDataSet()
        {
            return (DataSet)lstDataSets.SelectedItem;
        }

        public void selectDataSet(DataSet dataSet)
        {
            lstDataSets.SelectedItem = null;
            lstDataSets.SelectedItem = dataSet;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Globals.ExcelAddIn.Application.ActiveWindow.Activate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Variable> independentVariables = new List<Variable>();
            List<Variable> dependentVariables = new List<Variable>();
            foreach (DataGridViewRow row in dgvDataSet.Rows)
            {
                if (Convert.ToBoolean(row.Cells[dgv_VariablesX.Name].Value))
                {
                    independentVariables.Add((Variable)row.DataBoundItem);
                }
                if (Convert.ToBoolean(row.Cells[dgv_VariablesY.Name].Value))
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
            bool check = presenter.checkInput(selectedDataSet(), independentVariables, dependentVariables[0], txtProbability.Text, txtMisclassification0.Text, txtMisclassification1.Text);
            if (check)
            {
                Close();
                Globals.ExcelAddIn.Application.ActiveWindow.Activate();
            }
        }
    }
}