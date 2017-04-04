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

        public void checkInput(bool RChecked, bool XChecked, bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet)
        {
            if ((RChecked || XChecked) && (rdbAllObservations || rdbObservationsInRange || rdbPreviousData) && (dataSet != null))
            {
                generateChart(RChecked, XChecked, rdbAllObservations, rdbObservationsInRange, rdbPreviousData, dataSet);
            }
            else
                MessageBox.Show("Please complete all fields on the form to generate XRChart", "XR-Chart error");
        }

        public void generateChart(bool RChecked, bool XChecked, bool rdbAllObservations, bool rdbObservationsInRange, bool rdbPreviousData, DataSet dataSet)
        {
            var sheet = WorksheetHelper.NewWorksheet("XR Chart");
            if (RChecked && XChecked)
            {
                offset = 300;
            }
            else offset = 0;

            if (XChecked) {
                var Xcharts = (ChartObjects)sheet.ChartObjects();
                var chartObject = Xcharts.Add(100, 50, 400, 300);
                var Xchart = chartObject.Chart;
                Xchart.ChartType = XlChartType.xlXYScatter;
                Xchart.ChartWizard(Source: dataSets(), Title: "X-Chart " + dataSet.Name, HasLegend: true);
                var seriesCollection = (SeriesCollection)Xchart.SeriesCollection();
            }
            if (RChecked)
            {
                var Rcharts = (ChartObjects)sheet.ChartObjects();
                var RchartObject = Rcharts.Add(100, 50 + offset, 400, 300);
                var Rchart = RchartObject.Chart;
                Rchart.ChartType = XlChartType.xlXYScatter;
                Rchart.ChartWizard(Source: dataSets(), Title: "R-Chart " + dataSet.Name, HasLegend: true);
                var seriesCollection = (SeriesCollection)Rchart.SeriesCollection();
            }
            
        }
    }
}
