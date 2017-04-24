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

        public bool checkInput(bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet, string uiTextBox_StopIndex, string uiTextBox_StartIndex)
        {
            int startindex = Convert.ToInt16(uiTextBox_StartIndex);
            int stopindex = Convert.ToInt16(uiTextBox_StopIndex);

            if ((rdbAllObservations || rdbObservationsInRange || rdbPreviousData) && (dataSet != null) && (startindex <= stopindex))
            {

                offset = 320;

                if (rdbAllObservations || rdbPreviousData)
                {
                    startindex = 0;
                    stopindex = dataSet.amountOfVariables();
                }

                _Worksheet sheet = WorksheetHelper.NewWorksheet("XR Chart");
                
                generateXRChart(startindex, stopindex, dataSet, offset, sheet);
             
                return true;
            }
            else
                MessageBox.Show("Please correct all fields to generate X/R-Chart", "XR-Chart error");
            return false;
        }


        public void generateXRChart(int startindex, int stopindex, DataSet dataSet,int offset, _Worksheet sheet)
        {
            int index = 0;
            int row = 1;
            int column = 1;
            double xControlLimitFactor, rControlLimitFactor1, rControlLimitFactor2;
            double[] averages = new double[dataSet.amountOfVariables()];
            double[] Rvalues = new double[dataSet.amountOfVariables()];
            double[] averageOfAverages = new double[dataSet.amountOfVariables()];
            double[] xChartUpperControlLimit = new double[dataSet.amountOfVariables()];
            double[] xChartLowerControlLimit = new double[dataSet.amountOfVariables()];
            double[] rChartUpperControlLimit = new double[dataSet.amountOfVariables()];
            double[] rChartLowerControlLimit = new double[dataSet.amountOfVariables()];
            double[] averageOfRvalues = new double[dataSet.amountOfVariables()];
            double[] RvaluesInRange = new double[stopindex - startindex];
            double[] averageOfAveragesInRange = new double[stopindex - startindex];
            int[] ArrayIndex = new int[dataSet.amountOfVariables()];
            double[] xChartConstants = new double[25] { 0.0, 1.880, 1.023, 0.729, 0.577, 0.483, 0.419, 0.373, 0.337, 0.308, 0.285, 0.266, 0.249, 0.235, 0.223, 0.212, 0.203, 0.194, 0.187, 0.180, 0.173, 0.167, 0.162, 0.157, 0.153 };
            double[] rChartConstants1 = new double[25] { 0, 0, 0, 0, 0, 0, 0.076, 0.136, 0.184, 0.223, 0.256, 0.283, 0.307, 0.328, 0.347, 0.363, 0.378, 0.391, 0.403, 0.415, 0.425, 0.434, 0.443, 0.451, 0.459 };
            double[] rChartConstants2 = new double[25] { 0, 3.267, 2.574, 2.282, 2.114, 2.004, 1.924, 1.864, 1.816, 1.777, 1.744, 1.717, 1.693, 1.672, 1.653, 1.637, 1.662, 1.607, 1.597, 1.585, 1.575, 1.566, 1.557, 1.548, 1.541 };
            sheet.Cells[row, column] = "Index";
            sheet.Cells[row, column + 1] = "Observation";
            sheet.Cells[row, column + 2] = "Average";
            sheet.Cells[row, column + 3] = "Max";
            sheet.Cells[row, column + 4] = "Min";
            sheet.Cells[row, column + 5] = "R";

            for (index = 0; index < dataSet.amountOfVariables(); index++)
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
                if (cellValue < -214682680) cellValue = 0; // if cellValue is the result of a division by 0, set value to 0
                averages[index] = cellValue;
                cellValue = (double)(sheet.Cells[row, column + 5] as Range).Value;
                Rvalues[index] = cellValue;
            }

            for(index = startindex; index < stopindex; index++)
            {
                RvaluesInRange[index-startindex] = Rvalues[index];
                averageOfAveragesInRange[index-startindex] = averages[index];
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

            for (index = 0; index < dataSet.amountOfVariables(); index++)
            {
                averageOfAverages[index] = averages.Average();
                xChartUpperControlLimit[index] = averageOfAveragesInRange.Average() + (xControlLimitFactor * Rvalues.Average());
                xChartLowerControlLimit[index] = averageOfAveragesInRange.Average() - (xControlLimitFactor * Rvalues.Average());
                averageOfRvalues[index] = Rvalues.Average();
                rChartUpperControlLimit[index] = RvaluesInRange.Average() * rControlLimitFactor2;
                rChartLowerControlLimit[index] = RvaluesInRange.Average() * rControlLimitFactor1;
            }

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
