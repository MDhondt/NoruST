﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using NoruST.Domain;
using NoruST.Forms;
using NoruST.Models;
using DataSet = NoruST.Domain.DataSet;

namespace NoruST.Presenters
{
    public class OneVariableSummaryPresenter
    {
        private OneVariableSummaryForm view;
        private OneVariableSummaryModel model;
        private DataSetManagerPresenter dataSetPresenter;

        public OneVariableSummaryPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new OneVariableSummaryModel();
        }

        public OneVariableSummaryModel getModel()
        {
            return model;
        }

        public void openView()
        {
            view = view.createAndOrShowForm();
            view.setPresenter(this);
        }

        public BindingList<DataSet> dataSets()
        {
            return dataSetPresenter.getModel().getDataSets();
        }

        public void createSummaryStatistics(DataSet dataSet, List<Variable> variables)
        {
          if (variables.Count == 0) return;
            _Worksheet worksheet = WorksheetHelper.NewWorksheet("One-Variable Summary");
            int column = 1;
            int row = 2;
            if (model.mean) worksheet.Cells[row++, column] = "Mean";
            if (model.variance) worksheet.Cells[row++, column] = "Variance";
            if (model.standardDeviation) worksheet.Cells[row++, column] = "Standard Deviation";
            if (model.skewness) worksheet.Cells[row++, column] = "Skewness";
            if (model.kurtosis) worksheet.Cells[row++, column] = "Kurtosis";
            if (model.median) worksheet.Cells[row++, column] = "Median";
            if (model.meanAbsDeviation) worksheet.Cells[row++, column] = "Mean Abs. Deviation";
            if (model.mode) worksheet.Cells[row++, column] = "Mode";
            if (model.minimum) worksheet.Cells[row++, column] = "Minimum";
            if (model.maximum) worksheet.Cells[row++, column] = "Maximum";
            if (model.range) worksheet.Cells[row++, column] = "Range";
            if (model.count) worksheet.Cells[row++, column] = "Count";
            if (model.sum) worksheet.Cells[row++, column] = "Sum";
            if (model.firstQuartile) worksheet.Cells[row++, column] = "First Quartile";
            if (model.thirdQuartile) worksheet.Cells[row++, column] = "Third Quartile";
            if (model.interquartileRange) worksheet.Cells[row++, column] = "Interquartile Range";
            ((Range) worksheet.Cells[row, column]).EntireColumn.AutoFit();
            row = 1;
            column = 2;
            foreach (Variable variable in variables)
            {
                worksheet.Cells[row++, column]= variable.name;
                if (model.mean) worksheet.Cells[row++, column] = "Mean";
                if (model.variance) worksheet.Cells[row++, column] = "Variance";
                if (model.standardDeviation) worksheet.Cells[row++, column] = "Standard Deviation";
                if (model.skewness) worksheet.Cells[row++, column] = "Skewness";
                if (model.kurtosis) worksheet.Cells[row++, column] = "Kurtosis";
                if (model.median) worksheet.Cells[row++, column] = "Median";
                if (model.meanAbsDeviation) worksheet.Cells[row++, column] = "Mean Abs. Deviation";
                if (model.mode) worksheet.Cells[row++, column] = "Mode";
                if (model.minimum) worksheet.Cells[row++, column] = "Minimum";
                if (model.maximum) worksheet.Cells[row++, column] = "Maximum";
                if (model.range) worksheet.Cells[row++, column] = "Range";
                if (model.count) worksheet.Cells[row++, column] = "Count";
                if (model.sum) worksheet.Cells[row++, column] = "Sum";
                if (model.firstQuartile) worksheet.Cells[row++, column] = "First Quartile";
                if (model.thirdQuartile) worksheet.Cells[row++, column] = "Third Quartile";
                if (model.interquartileRange) worksheet.Cells[row++, column] = "Interquartile Range";
                ((Range)worksheet.Cells[row, column]).EntireColumn.AutoFit();
                row = 1;
                column++;
            }

        }
    }
}