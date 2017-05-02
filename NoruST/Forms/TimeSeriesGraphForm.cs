﻿using System;
using System.Windows.Forms;
using NoruST.Forms;
using NoruST.Presenters;
using NoruST.Domain;


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
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton_Ok_Click(object sender, EventArgs e)
        {
            bool inputOk = presenter.checkInput(selectedDataSet());
            if (inputOk)
            {
                Close();
            }
        }
    }
}

