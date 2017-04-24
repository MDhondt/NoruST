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

        public bool checkInput(bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet, string uiTextBox_StopIndex, string uiTextBox_StartIndex)
        {
            int startindex = Convert.ToInt16(uiTextBox_StartIndex);
            int stopindex = Convert.ToInt16(uiTextBox_StopIndex);

            if ((rdbAllObservations || rdbObservationsInRange || rdbPreviousData) && (dataSet != null) && (startindex <= stopindex))
            {
                
                if (rdbAllObservations || rdbPreviousData)
                {
                    startindex = 0;
                    stopindex = dataSet.amountOfVariables();
                }
      
                _Worksheet sheet = WorksheetHelper.NewWorksheet("P Chart");

                generatePChart(startindex, stopindex, dataSet, sheet);
                
                return true;
            }
            else
                MessageBox.Show("Please correct all fields to generate P-Chart", "P-Chart error");
                return false;
        }

        private void generatePChart(int startindex, int stopindex, DataSet dataSet, _Worksheet sheet)
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
                var cellValue = (double)(sheet.Cells[row, column + 2] as Range).Value;
                averages[index-startindex] = cellValue;
                ArrayIndex[index-startindex] = index;
            }

                var Xcharts = (ChartObjects)sheet.ChartObjects();
                var XchartObject = Xcharts.Add(340, 20, 550, 300);
                var Xchart = XchartObject.Chart;
                Xchart.ChartType = XlChartType.xlLineMarkers;
                Xchart.ChartWizard(Title: "P-Chart " + dataSet.Name, HasLegend: true);
                var XseriesCollection = (SeriesCollection)Xchart.SeriesCollection();
                var xseries = XseriesCollection.NewSeries();
                xseries.Name = ("Proportion");
                xseries.XValues = ArrayIndex;
                xseries.Values = averages;
           
        }
    }
}
