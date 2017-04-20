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
    public class PChartPresenter
    {
        private PChartForm view;
        private PChartModel model;
        private DataSetManagerPresenter dataSetPresenter;
        private int offset;

        public PChartPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new PChartModel();
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

        public bool checkInput(bool RChecked, bool XChecked, bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet, string uiTextBox_StopIndex, string uiTextBox_StartIndex)
        {
            int startindex = Convert.ToInt16(uiTextBox_StartIndex);
            int stopindex = Convert.ToInt16(uiTextBox_StopIndex);

            if ((RChecked || XChecked) && (rdbAllObservations || rdbObservationsInRange || rdbPreviousData) && (dataSet != null) && (startindex <= stopindex))
            {
                
                if (RChecked && XChecked)
                {
                    offset = 300;
                }
                else offset = 0;

                if (rdbAllObservations)
                {
                    startindex = 0;
                    stopindex = dataSet.amountOfVariables();
                }

                _Worksheet sheet = WorksheetHelper.NewWorksheet("XR Chart");
                if (XChecked)
                {
                    generateXChart(startindex, stopindex, dataSet, sheet);
                }

                if (RChecked)
                {
                    generateRChart(startindex, stopindex, dataSet, offset, sheet);
                }
                return true;
            }
            else
                MessageBox.Show("Please correct all fields to generate X/R-Chart", "XR-Chart error");
                return false;
        }

        private double[] loadData(DataSet dataSet)
        {
            double[,] cellValues = new double[dataSet.amountOfVariables(), dataSet.rangeSize() + 1];
            cellValues = dataSet.getRange().Value as double[,];
            double[] avgArray = new double[dataSet.amountOfVariables()];  

            if (dataSet.variableInColumns())
            {
                for (var k = 0; k < dataSet.amountOfVariables(); k++)
                {
                    double sum = 0;
                    for(var l = 0; l < dataSet.rangeSize(); l++)
                    {
                        sum = sum + Convert.ToDouble(cellValues[l, k]);
                    }
                    avgArray[k] = sum/dataSet.rangeSize();
                }
            }

            if (!dataSet.variableInColumns())
            {
                for (var k = 0; k < dataSet.amountOfVariables(); k++)
                {
                    double sum = 0;
                    for (var l = 0; l < dataSet.rangeSize(); l++)
                    {
                        sum = sum + Convert.ToDouble(cellValues[k, l]);
                    }
                    avgArray[k] = sum/dataSet.rangeSize();
                }
            }
            return avgArray;
        }

        //private void calculateXChart(double[,] cellValues, int stopindex, int startindex, DataSet dataSet)
        //{
        //    for(int x = startindex; x < stopindex; x++)
        //    {
        //       cellValues.s
        //    }
        //}

        private void generateXChart(int startindex, int stopindex, DataSet dataSet, _Worksheet sheet)
        {
            int index = 0;
            int row = 1;
            int column = 1;
            double[] averages = new double[stopindex - startindex];
            int[] ArrayIndex = new int[stopindex-startindex];
            sheet.Cells[row, column] = "Index";
            sheet.Cells[row, column + 1] = "Observation";
            sheet.Cells[row, column + 2] = "Average";
            
            for(index = startindex; index < stopindex; index ++)
            {
                row++;
                sheet.Cells[row, column] = index;
                sheet.Cells[row, column + 1] = dataSet.getVariables()[index].name;
                sheet.Cells[row, column + 2] = "=AVERAGE("+ dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
                ArrayIndex[index] = index;
            }

            MessageBox.Show("sum variables positie 1 " + loadData(dataSet));

                var Xcharts = (ChartObjects)sheet.ChartObjects();
                var XchartObject = Xcharts.Add(250, 50, 400, 300);
                var Xchart = XchartObject.Chart;
                Xchart.ChartType = XlChartType.xlLineMarkers;
                Xchart.ChartWizard(Title: "X-Chart " + dataSet.Name, HasLegend: true);
                var XseriesCollection = (SeriesCollection)Xchart.SeriesCollection();
                var xseries = XseriesCollection.NewSeries();
                xseries.Name = ("Observation Averages");
                xseries.XValues = ArrayIndex;
                xseries.Values = loadData(dataSet);
           
        }

        private void generateRChart(int startindex, int stopindex, DataSet dataSet, int offset, _Worksheet sheet)
        {
                var Rcharts = (ChartObjects)sheet.ChartObjects();
                var RchartObject = Rcharts.Add(250, 50 + offset, 400, 300);
                var Rchart = RchartObject.Chart;
                Rchart.ChartType = XlChartType.xlLineMarkers;
                Rchart.ChartWizard(Title: "R-Chart " + dataSet.Name, HasLegend: true);
                var RseriesCollection = (SeriesCollection)Rchart.SeriesCollection();
                var rseries = RseriesCollection.Add();
                //rseries.Values(model.subsampleAverages(dataSet));
                //rseries.XValues(model.dataSet.getVariables());
        }
    }
}
