using System;
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
    public class TimeSeriesGraphPresenter
    {
        private TimeSeriesGraphForm view;
        private TimeSeriesGraphModel model;
        private DataSetManagerPresenter dataSetPresenter;

        public TimeSeriesGraphPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new TimeSeriesGraphModel();
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

        public bool checkInput(DataSet dataSet, bool allObservations, bool observationsRange, string uiTextBox_StartIndex, string uiTextBox_StopIndex)
        {

            int startindex = Convert.ToInt16(uiTextBox_StartIndex);
            int stopindex = Convert.ToInt16(uiTextBox_StopIndex);

            if ((dataSet != null) && (allObservations || observationsRange) && (startindex <= stopindex) && (startindex >= 0 && stopindex >= 0))
            {

                if (allObservations)
                {
                    startindex = 0;
                    stopindex = dataSet.amountOfVariables() - 1;
                }

                if (observationsRange && stopindex >= dataSet.amountOfVariables())
                {
                    stopindex = dataSet.amountOfVariables() - 1;
                }

                _Worksheet sheet = WorksheetHelper.NewWorksheet("Time Series Graph");
                     generateChart(startindex, stopindex, dataSet, sheet);
                return true;
            }
            else
                MessageBox.Show("Please correct all fields to generate Time Series Graph", "Time Series Graph error");
            return false;
        }


        public void generateChart(int startindex, int stopindex, DataSet dataSet, _Worksheet sheet)
        {
            int index = 0;
            int row = 1;
            int column = 1;
            sheet.Cells[row, column] = "Index";
            sheet.Cells[row, column + 1] = "Observation";
            double[] values = new double[dataSet.amountOfVariables()];
            //double[] averages = new double[dataSet.amountOfVariables()];
            int[] Index = new int[dataSet.amountOfVariables()];

            for (index = startindex; index < stopindex; index++)
            {
                row++;
                sheet.Cells[row, column] = index;
                sheet.Cells[row, column + 1] = dataSet.getVariables()[index].name;
                sheet.Cells[row, column + 2] = "=AVERAGE(" + dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
                Index[index] = index;
                var cellValue = (double)(sheet.Cells[row, column + 2] as Range).Value;
                if (cellValue < -214682680) cellValue = 0; // if cellValue is the result of a division by 0, set value to 0
                values[index] = cellValue;
            }

            //for (index = 0; index < dataSet.amountOfVariables(); index++)
            //{
            //    averages[index] = values.Average();
            //}

            var Xcharts = (ChartObjects)sheet.ChartObjects();
                var XchartObject = Xcharts.Add(340, 20, 550, 300);
                var Xchart = XchartObject.Chart;
                Xchart.ChartType = XlChartType.xlXYScatterLinesNoMarkers;
                Xchart.ChartWizard(Title: "Time Series Graph " + dataSet.Name, HasLegend: true);
                var XseriesCollection = (SeriesCollection)Xchart.SeriesCollection();
                var valueseries = XseriesCollection.NewSeries();
                valueseries.Name = ("Observations");
                valueseries.Values = values;
                valueseries.XValues = Index;
            }
    }
}
