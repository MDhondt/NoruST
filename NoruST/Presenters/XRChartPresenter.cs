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

        public void checkInput(bool RChecked, bool XChecked, bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet, string uiTextBox_StopIndex, string uiTextBox_StartIndex)
        {
            int startindex = Convert.ToInt16(uiTextBox_StartIndex);
            int stopindex = Convert.ToInt16(uiTextBox_StopIndex);

            if ((RChecked || XChecked) && (rdbAllObservations || rdbObservationsInRange || rdbPreviousData))
            {

                if (RChecked && XChecked)
                {
                    offset = 300;
                }
                else offset = 0;

                _Worksheet sheet = WorksheetHelper.NewWorksheet("XR Chart");
                if (XChecked)
                {
                    calculateXChart();
                    generateXChart(rdbAllObservations, rdbObservationsInRange, rdbPreviousData, dataSet, sheet);
                }
                if (RChecked)
                {
                    generateRChart(rdbAllObservations, rdbObservationsInRange, rdbPreviousData, dataSet, offset, sheet);
                }
            }
            else
                MessageBox.Show("Please complete all fields on the form to generate X/R-Chart", "XR-Chart error");
        }

        private void calculateXChart()
        {

        }

        private void generateXChart(bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet, _Worksheet sheet)
        {
            sheet.Cells[1][1] = 1;
                var Xcharts = (ChartObjects)sheet.ChartObjects();
                var XchartObject = Xcharts.Add(100, 50, 400, 300);
                var Xchart = XchartObject.Chart;
                Xchart.ChartType = XlChartType.xlLineMarkers;
                Xchart.ChartWizard(Title: "X-Chart " + dataSet.Name, HasLegend: true);
                var XseriesCollection = (SeriesCollection)Xchart.SeriesCollection();
                var xseries = XseriesCollection.Add();
                xseries.Values(model.subsampleAverages(dataSet));
                xseries.XValues(model.dataSet.getVariables());
        }

        private void generateRChart(bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet, int offset, _Worksheet sheet)
        {
                var Rcharts = (ChartObjects)sheet.ChartObjects();
                var RchartObject = Rcharts.Add(100, 50 + offset, 400, 300);
                var Rchart = RchartObject.Chart;
                Rchart.ChartType = XlChartType.xlLineMarkers;
                Rchart.ChartWizard(Title: "R-Chart " + dataSet.Name, HasLegend: true);
                var RseriesCollection = (SeriesCollection)Rchart.SeriesCollection();
                var rseries = RseriesCollection.Add();
                rseries.Values(model.subsampleAverages(dataSet));
                rseries.XValues(model.dataSet.getVariables());
        }
    }
}
