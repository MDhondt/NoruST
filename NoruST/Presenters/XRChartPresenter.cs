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
    public class XRChartPresenter
    {
        private XRChartForm view;
        private XRChartModel model;
        private DataSetManagerPresenter dataSetPresenter;
        private int offset;

        public XRChartPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new XRChartModel();
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
                    offset = 320;
                }
                else offset = 0;

                if (rdbAllObservations)
                {
                    startindex = 0;
                    stopindex = dataSet.amountOfVariables();
                }
                _Worksheet sheet = WorksheetHelper.NewWorksheet("XR Chart");
                
                generateXRChart(startindex, stopindex, dataSet, offset, sheet, XChecked, RChecked);
             
                return true;
            }
            else
                MessageBox.Show("Please correct all fields to generate X/R-Chart", "XR-Chart error");
            return false;
        }

        //private double[] loadData(DataSet dataSet)
        //{
        //    Array cellValues = (Array)(dataSet.getRange().Cells.Value2);
        //    double[] avgArray = new double[dataSet.amountOfVariables()];  

        //    if (dataSet.variableInColumns())
        //    {
        //        for (var k = 0; k < dataSet.amountOfVariables(); k++)
        //        {
        //            double sum = 0;
        //            for(var l = 0; l < dataSet.rangeSize(); l++)
        //            {
        //                sum = sum + Convert.ToDouble(cellValues.GetValue(k,l));
        //            }
        //            avgArray[k] = sum/dataSet.rangeSize();
        //        }
        //    }

        //    if (!dataSet.variableInColumns())
        //    {
        //        for (var k = 0; k < dataSet.amountOfVariables(); k++)
        //        {
        //            double sum = 0;
        //            for (var l = 0; l < dataSet.rangeSize(); l++)
        //            {
        //                sum = sum + Convert.ToDouble(cellValues.GetValue(l,k));
        //            }
        //            avgArray[k] = sum/dataSet.rangeSize();
        //        }
        //    }
        //    return avgArray;
        //}

        //private void calculateXChart(double[,] cellValues, int stopindex, int startindex, DataSet dataSet)
        //{
        //    for(int x = startindex; x < stopindex; x++)
        //    {
        //       cellValues.s
        //    }
        //}

        //public void generateOutput(int startindex,int stopindex,DataSet dataSet, _Worksheet sheet)
        //{
        //    int index = 0;
        //    int row = 1;
        //    int column = 1;
        //    double controlLimitFactor;
        //    double[] averages = new double[stopindex - startindex];
        //    double[] Rvalues = new double[stopindex - startindex];
        //    double[] averageOfAverages = new double[stopindex - startindex];
        //    double[] upperControlLimit = new double[stopindex - startindex];
        //    double[] lowerControlLimit = new double[stopindex - startindex];
        //    int[] ArrayIndex = new int[stopindex - startindex];
        //    double[] xChartConstants = new double[25] { 0.0, 1.880, 1.023, 0.729, 0.577, 0.483, 0.419, 0.373, 0.337, 0.308, 0.285, 0.266, 0.249, 0.235, 0.223, 0.212, 0.203, 0.194, 0.187, 0.180, 0.173, 0.167, 0.162, 0.157, 0.153 };
        //    sheet.Cells[row, column] = "Index";
        //    sheet.Cells[row, column + 1] = "Observation";
        //    sheet.Cells[row, column + 2] = "Average";
        //    sheet.Cells[row, column + 3] = "Max";
        //    sheet.Cells[row, column + 4] = "Min";
        //    sheet.Cells[row, column + 5] = "R";

        //    for (index = startindex; index < stopindex; index++)
        //    {
        //        row++;
        //        sheet.Cells[row, column] = index;
        //        sheet.Cells[row, column + 1] = dataSet.getVariables()[index].name;
        //        sheet.Cells[row, column + 2] = "=AVERAGE(" + dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
        //        sheet.Cells[row, column + 3] = "=MAX(" + dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
        //        sheet.Cells[row, column + 4] = "=MIN(" + dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
        //        sheet.Cells[row, column + 5] = (double)(sheet.Cells[row, column + 3] as Range).Value - (double)(sheet.Cells[row, column + 4] as Range).Value;
        //        ArrayIndex[index] = index;
        //        var cellValue = (double)(sheet.Cells[row, column + 2] as Range).Value;
        //        averages[index] = cellValue;
        //        cellValue = (double)(sheet.Cells[row, column + 5] as Range).Value;
        //        Rvalues[index] = cellValue;
        //    }

        //    if (dataSet.getVariableNamesInFirstRowOrColumn())
        //    {
        //        controlLimitFactor = xChartConstants[dataSet.rangeSize() - 1];
        //    }
        //    else
        //        controlLimitFactor = xChartConstants[dataSet.rangeSize()];


        //    for (index = startindex; index < stopindex; index++)
        //    {
        //        averageOfAverages[index] = averages.Average();
        //        upperControlLimit[index] = averages.Average() + (controlLimitFactor * Rvalues.Average());
        //        lowerControlLimit[index] = averages.Average() - (controlLimitFactor * Rvalues.Average());
        //    }
        //}


        public void generateXRChart(int startindex, int stopindex, DataSet dataSet,int offset, _Worksheet sheet, bool xChecked, bool rChecked)
        {
            int index = 0;
            int row = 1;
            int column = 1;
            double xControlLimitFactor, rControlLimitFactor1, rControlLimitFactor2;
            double[] averages = new double[stopindex - startindex];
            double[] Rvalues = new double[stopindex - startindex];
            double[] averageOfAverages = new double[stopindex - startindex];
            double[] xChartUpperControlLimit = new double[stopindex - startindex];
            double[] xChartLowerControlLimit = new double[stopindex - startindex];
            double[] rChartUpperControlLimit = new double[stopindex - startindex];
            double[] rChartLowerControlLimit = new double[stopindex - startindex];
            double[] averageOfRvalues = new double[stopindex - startindex];
            int[] ArrayIndex = new int[stopindex - startindex];
            double[] xChartConstants = new double[25] { 0.0, 1.880, 1.023, 0.729, 0.577, 0.483, 0.419, 0.373, 0.337, 0.308, 0.285, 0.266, 0.249, 0.235, 0.223, 0.212, 0.203, 0.194, 0.187, 0.180, 0.173, 0.167, 0.162, 0.157, 0.153 };
            double[] rChartConstants1 = new double[25] { 0, 0, 0, 0, 0, 0, 0.076, 0.136, 0.184, 0.223, 0.256, 0.283, 0.307, 0.328, 0.347, 0.363, 0.378, 0.391, 0.403, 0.415, 0.425, 0.434, 0.443, 0.451, 0.459 };
            double[] rChartConstants2 = new double[25] { 0, 3.267, 2.574, 2.282, 2.114, 2.004, 1.924, 1.864, 1.816, 1.777, 1.744, 1.717, 1.693, 1.672, 1.653, 1.637, 1.662, 1.607, 1.597, 1.585, 1.575, 1.566, 1.557, 1.548, 1.541 };
            sheet.Cells[row, column] = "Index";
            sheet.Cells[row, column + 1] = "Observation";
            sheet.Cells[row, column + 2] = "Average";
            sheet.Cells[row, column + 3] = "Max";
            sheet.Cells[row, column + 4] = "Min";
            sheet.Cells[row, column + 5] = "R";

            for (index = startindex; index < stopindex; index++)
            {
                row++;
                sheet.Cells[row, column] = index;
                sheet.Cells[row, column + 1] = dataSet.getVariables()[index].name;
                sheet.Cells[row, column + 2] = "=AVERAGE(" + dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
                sheet.Cells[row, column + 3] = "=MAX(" + dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
                sheet.Cells[row, column + 4] = "=MIN(" + dataSet.getWorksheet().Name + "!" + dataSet.getVariables()[index].Range + ")";
                sheet.Cells[row, column + 5] = (double)(sheet.Cells[row, column + 3] as Range).Value - (double)(sheet.Cells[row, column + 4] as Range).Value;
                ArrayIndex[index] = index;
                var cellValue = (double)(sheet.Cells[row, column + 2] as Range).Value;
                averages[index] = cellValue;
                cellValue = (double)(sheet.Cells[row, column + 5] as Range).Value;
                Rvalues[index] = cellValue;
            }

            if (dataSet.getVariableNamesInFirstRowOrColumn())
            {
                xControlLimitFactor = xChartConstants[dataSet.rangeSize() - 1];
                rControlLimitFactor1 = rChartConstants1[dataSet.rangeSize() - 1];
                rControlLimitFactor2 = rChartConstants2[dataSet.rangeSize() - 1];
            }
            else
                xControlLimitFactor = xChartConstants[dataSet.rangeSize()];
                rControlLimitFactor1 = rChartConstants1[dataSet.rangeSize()];
                rControlLimitFactor2 = rChartConstants2[dataSet.rangeSize()];

            for (index = startindex; index < stopindex; index++)
            {
                averageOfAverages[index] = averages.Average();
                xChartUpperControlLimit[index] = averages.Average() + (xControlLimitFactor * Rvalues.Average());
                xChartLowerControlLimit[index] = averages.Average() - (xControlLimitFactor * Rvalues.Average());
                averageOfRvalues[index] = Rvalues.Average();
                rChartUpperControlLimit[index] = Rvalues.Average() * rControlLimitFactor1;
                rChartLowerControlLimit[index] = Rvalues.Average() * rControlLimitFactor2;
            }

            if (xChecked)
            {
                var Xcharts = (ChartObjects)sheet.ChartObjects();
                var XchartObject = Xcharts.Add(340, 20, 550, 300);
                var Xchart = XchartObject.Chart;
                Xchart.ChartType = XlChartType.xlLineMarkers;
                Xchart.ChartWizard(Title: "X-Chart " + dataSet.Name, HasLegend: true);
                var XseriesCollection = (SeriesCollection)Xchart.SeriesCollection();
                var avgseries = XseriesCollection.NewSeries();
                var avgAvgseries = XseriesCollection.NewSeries();
                var UCLseries = XseriesCollection.NewSeries();
                var LCLseries = XseriesCollection.NewSeries();
                avgseries.Name = ("Observation Averages");
                avgAvgseries.Name = ("Center Line");
                UCLseries.Name = ("UCL");
                LCLseries.Name = ("LCL");
                avgseries.Values = averages;
                avgAvgseries.Values = averageOfAverages;
                UCLseries.Values = xChartUpperControlLimit;
                LCLseries.Values = xChartLowerControlLimit;
                avgseries.XValues = ArrayIndex;
            }

            if (rChecked)
            {
                var Rcharts = (ChartObjects)sheet.ChartObjects();
                var RchartObject = Rcharts.Add(340, 20 + offset, 550, 300);
                var Rchart = RchartObject.Chart;
                Rchart.ChartType = XlChartType.xlLineMarkers;
                Rchart.ChartWizard(Title: "R-Chart " + dataSet.Name, HasLegend: true);
                var RseriesCollection = (SeriesCollection)Rchart.SeriesCollection();
                var rSeries = RseriesCollection.NewSeries();
                var averageRSeries = RseriesCollection.NewSeries();
                var UCLSeries = RseriesCollection.NewSeries();
                var LCLSeries = RseriesCollection.NewSeries();
                rSeries.Name = ("Observation R");
                averageRSeries.Name = ("Center Line");
                UCLSeries.Name = ("UCL");
                LCLSeries.Name = ("LCL");
                rSeries.Values = Rvalues;
                averageRSeries.Values = averageOfRvalues;
                UCLSeries.Values = rChartUpperControlLimit;
                LCLSeries.Values = rChartLowerControlLimit;
                rSeries.XValues = ArrayIndex;
            }
        }
    }
}
