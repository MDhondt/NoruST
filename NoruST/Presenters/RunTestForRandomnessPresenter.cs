﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoruST.Forms;
using NoruST.Models;
using NoruST.Presenters;
using NoruST.Domain;
using DataSet = NoruST.Domain.DataSet;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace NoruST.Presenters
{
    public class RunsTestForRandomnessPresenter
    {
        private RunsTestForRandomnessForm view;
        private RunsTestForRandomnessModel model;
        private DataSetManagerPresenter dataSetPresenter;

        public RunsTestForRandomnessPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new RunsTestForRandomnessModel();
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

        public bool checkInput(List<Variable> variables, DataSet selectedDataSet, bool rdbMean, bool rdbMedian, bool rdbCustomValue, string CustomCutoffValue)
        {
            if (variables.Count == 0)
            {
                MessageBox.Show("Please correct all fields to generate Runs Test.");
                return false; // wanneer de gebruiker geen variabele geselecteerd heeft, stop functie
            }
            _Worksheet worksheet = WorksheetHelper.NewWorksheet("Runs test");
            int column = 1;
            int row = 2;
            worksheet.Cells[row, column] = "Runs test for randomness"; // schrijf strings naar worksheet 
            worksheet.Cells[row++, column] = "Observations";
            if (rdbMean) worksheet.Cells[row++, column] = "Mean";
            if (rdbMedian) worksheet.Cells[row++, column] = "Median";
            if (rdbCustomValue) worksheet.Cells[row++, column] = "Custom cutoff Value";
            worksheet.Cells[row++, column] = "Below cutoff";
            worksheet.Cells[row++, column] = "Above cutoff";
            worksheet.Cells[row++, column] = "Number of runs";
            worksheet.Cells[row++, column] = "E(R)";
            worksheet.Cells[row++, column] = "Stddev(R)";
            worksheet.Cells[row++, column] = "Z-Value";
            worksheet.Cells[row++, column] = "P-Value (two-tailed)";
            ((Range)worksheet.Cells[row, column]).EntireColumn.AutoFit();

            row = 1;
            column = 2;
            foreach (Variable variable in variables) // deze loop wordt herhaald voor elke geselecteerde variabele van datagridview
            {
                worksheet.Cells[row++, column] = variable.name; // schrijf naam variabele naar worksheet
                var range = variable.getRange().Address(true, true, true); // sla range variabele op in "range"
                worksheet.Cells[row++, column] = selectedDataSet.rangeSize(); // schrijf de hoeveelheid gegevens in de variabele naar worksheet
                var ntotal = selectedDataSet.rangeSize(); 
                if (rdbMean) worksheet.Cells[row++, column] = "=AVERAGE(" + range + ")"; // schrijf afhankelijk van de gebruikersinput de cutoffvalue naar worksheet
                if (rdbMedian) worksheet.Cells[row++, column] = "=MEDIAN(" + range + ")"; 
                if (rdbCustomValue) worksheet.Cells[row++, column] = CustomCutoffValue;
                var cutoffValue = (double)worksheet.Cells[row-1, column].Value; // lees de cutoffvalue vanuit excel en sla ze op in variabele 'cutoffvalue'
                int amountOfRuns = calculateRuns(worksheet, selectedDataSet, variable.getRange(), cutoffValue); // roep functie calculateRuns aan en sla het resultaat op in amountofruns
                worksheet.WriteFunction(row++, column, "COUNTIF(" + range + ",\"<\"&" + AddressConverter.CellAddress(row - 2, column) + ")"); // schrijf functie voor het berekenen van #above cutoff naar worksheet
                worksheet.WriteFunction(row++, column, "COUNTIF(" + range + ",\">\"&" + AddressConverter.CellAddress(row - 3, column) + ")"); // schrijf functie voor het berekenen van #below cutoff naar worksheet
                worksheet.Cells[row++, column] = amountOfRuns; // schrijf het resultaat van functie calculate Runs naar worksheet
                worksheet.WriteFunction(row++, column, "(2*" + AddressConverter.CellAddress(row - 4, column) + "*" + AddressConverter.CellAddress(row - 3, column) + ")/(" + AddressConverter.CellAddress(row - 6, column) + ")"); // schrijf overige functies naar worksheet
                worksheet.WriteFunction(row++, column, "SQRT(((" + AddressConverter.CellAddress(row - 2, column) + "-1)*(" + AddressConverter.CellAddress(row - 2, column) + "-2))/" + AddressConverter.CellAddress(row - 7, column) + ")");
                worksheet.WriteFunction(row++, column, "(" + AddressConverter.CellAddress(row - 4, column) + "-" + AddressConverter.CellAddress(row - 3, column) + ")/" + AddressConverter.CellAddress(row - 2, column));
                worksheet.WriteFunction(row++, column, "2*(1-NORMSDIST(ABS(" + AddressConverter.CellAddress(row - 2, column) + ")))");
                ((Range)worksheet.Cells[row, column]).EntireColumn.AutoFit(); 
                row = 1;
                column++;
            }
            return true;
        }

        private int calculateRuns(_Worksheet sheet, DataSet dataSet, Range range, double cutoff) // functie die het aantal runs bepaalt
        {
            int runs = 1;
            double[,] array = RangeHelper.To2DDoubleArray(range);
            double[] array2 = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i, 0];  
            }
            for(int i = 0; i < array.Length-1; i++)
            {
                if(Math.Sign(array2[i] - cutoff) != Math.Sign(array2[i+1] - cutoff))
                {
                    runs++;
                }
            }

            return runs;
        }
    }
}
