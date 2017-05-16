using NoruST.Analyses;
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

            bool check = presenter.checkInput(selectedDataSet(), variablesX, variablesY, txtProbability.Text, txtMisclassification0.Text, txtMisclassification1.Text);
            if (check)
            {
                Close();
            }
        }
    }
}