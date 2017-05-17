using System;
using System.Windows.Forms;
using NoruST.Forms;
using NoruST.Presenters;
using NoruST.Domain;
using System.Collections.Generic;

namespace NoruST.Forms
{ 
    public partial class LogisticRegressionForm : Form
    {
        private LogisticRegressionPresenter presenter;
        private const string formTitle = "NoruST - Logistic Regression";

        public LogisticRegressionForm()
        {
            InitializeComponent();
        }


        public void setPresenter(LogisticRegressionPresenter LogisticRegressionFormPresenter)
        {
            this.presenter = LogisticRegressionFormPresenter;
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
            List<Variable> variablesX = new List<Variable>();
            List<Variable> variablesY = new List<Variable>();
            foreach (DataGridViewRow row in dgvDataSet.Rows)
            {
                if (Convert.ToBoolean(row.Cells[dgv_VariablesX.Name].Value))
                {
                    variablesX.Add((Variable)row.DataBoundItem);
                }
                if (Convert.ToBoolean(row.Cells[dgv_VariablesY.Name].Value))
                {
                    variablesY.Add((Variable)row.DataBoundItem);
                }
            }

            bool check = presenter.checkInput(selectedDataSet(), variablesX, variablesY);
            if (check)
            {
                Close();
                Globals.ExcelAddIn.Application.ActiveWindow.Activate();
            }
        }
    }
}