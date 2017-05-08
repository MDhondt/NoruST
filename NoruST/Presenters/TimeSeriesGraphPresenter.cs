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

        public bool checkInput(List<Variable> variables, DataSet dataSet, bool allObservations, bool observationsRange, string uiTextBox_StartIndex, string uiTextBox_StopIndex)
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
                foreach (Variable variable in variables)
                {
                    generateChart(startindex, stopindex, variable, sheet);
                }
                return true;
            }
            else
                MessageBox.Show("Please correct all fields to generate Time Series Graph", "Time Series Graph error");
            return false;
        }


        public void generateChart(int startindex, int stopindex, Variable variable, _Worksheet sheet)
        {


            //var Xcharts = (ChartObjects)sheet.ChartObjects();
            //    var XchartObject = Xcharts.Add(340, 20, 550, 300);
            //    var Xchart = XchartObject.Chart;
            //    Xchart.ChartType = XlChartType.xlXYScatterLinesNoMarkers;
            //    Xchart.ChartWizard(Title: "Time Series Graph " + dataSet.Name, HasLegend: true);
            //    var XseriesCollection = (SeriesCollection)Xchart.SeriesCollection();
            //    var valueseries = XseriesCollection.NewSeries();
            //    valueseries.Name = ("Observations");
            //    valueseries.Values = values;
            //    valueseries.XValues = Index;
            }
    }
}
