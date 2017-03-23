using System;
using System.Windows.Forms;
using NoruST.Data;
using NoruST.Domain;
using NoruST.Presenters;

namespace NoruST.Forms
{
    public partial class LagForm : Form
    {
        private LagPresenter presenter;

        public LagForm()
        {
            InitializeComponent();
        }

        public void setPresenter(LagPresenter lagPresenter)
        {
            this.presenter = lagPresenter;
            bindModelToView();
            selectDataSet(selectedDataSet());
        }

        private void bindModelToView()
        {
            uiComboBox_DataSets.DataSource = presenter.dataSets();
            uiComboBox_DataSets.DisplayMember = "name";
            uiDataGridViewColumn_Name.DataPropertyName = "name";
            uiDataGridViewColumn_Range.DataPropertyName = "Range";
            uiComboBox_DataSets.SelectedIndexChanged += (obj, eventArgs) =>
            {
                if (selectedDataSet() == null) return;
                uiDataGridView_Variables.DataSource = selectedDataSet().getVariables();
                uiNumericUpDown_Lag.Maximum = selectedDataSet().rangeSize() - 1;
            };
        }

        private DataSet selectedDataSet()
        {
            return (DataSet)uiComboBox_DataSets.SelectedItem;
        }

        public void selectDataSet(DataSet dataSet)
        {
            uiComboBox_DataSets.SelectedItem = null;
            uiComboBox_DataSets.SelectedItem = dataSet;
        }

        private void uiButton_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiDataGridView_Variables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = 0;
            if (uiDataGridView_Variables.Rows.Count == 0 || e.ColumnIndex != columnIndex) return;
            var isChecked = (bool)uiDataGridView_Variables.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (!isChecked) return;
            foreach (DataGridViewRow row in uiDataGridView_Variables.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.Cells[columnIndex].Value = false;
                }
            }
        }
    }
}