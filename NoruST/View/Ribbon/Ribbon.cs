﻿using Microsoft.Office.Tools.Ribbon;
using NoruST.Forms;
using NoruST.Presenters;

namespace NoruST
{
    public partial class Ribbon
    {

        private DataSetManagerPresenter dataSetManagerPresenter;
        private LagPresenter lagPresenter;
        private XRChartPresenter xrChartPresenter;
        private PChartPresenter pChartPresenter;
        private DummyPresenter dummyPresenter;
        private ProcessCapabilityPresenter processCapabilityPresenter;
        private TimeSeriesGraphPresenter timeSeriesGraphPresenter;
        private OneVariableSummaryPresenter oneVariableSummaryPresenter;
        private RunsTestForRandomnessPresenter runsTestForRandomnessPresenter;
        private ForecastPresenter forecastPresenter;
        private CorrelationCovarianceForm correlationCovarianceForm;
        private HistogramPresenter histogramPresenter;
        private ScatterPlotPresenter scatterPlotPresenter;
        private BoxWhiskerPlotPresenter boxWhiskerPlotPresenter;
        private SampleSizeEstimationPresenter sampleSizeEstimationPresenter;
        private TimeSeriesGraphForm timeSeriesGraphForm;
        private RunsTestForRandomnessForm runsTestForRandomnessForm;
        private ForecastForm forecastForm;
        private RegressionForm regressionForm;
        private LogisticRegressionForm logisticRegressionForm;
        private DiscriminantAnalysisForm discriminantAnalysisForm;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            // Initialize the required classes to work.
            dataSetManagerPresenter = new DataSetManagerPresenter();
            lagPresenter = new LagPresenter(dataSetManagerPresenter);
            xrChartPresenter = new XRChartPresenter(dataSetManagerPresenter);
            pChartPresenter = new PChartPresenter(dataSetManagerPresenter);
            dummyPresenter = new DummyPresenter(dataSetManagerPresenter);
            processCapabilityPresenter = new ProcessCapabilityPresenter(dataSetManagerPresenter);
            timeSeriesGraphPresenter = new TimeSeriesGraphPresenter(dataSetManagerPresenter);
            oneVariableSummaryPresenter = new OneVariableSummaryPresenter(dataSetManagerPresenter);
            histogramPresenter = new HistogramPresenter(dataSetManagerPresenter);
            scatterPlotPresenter = new ScatterPlotPresenter(dataSetManagerPresenter);
            boxWhiskerPlotPresenter = new BoxWhiskerPlotPresenter(dataSetManagerPresenter);
            sampleSizeEstimationPresenter = new SampleSizeEstimationPresenter(dataSetManagerPresenter);
            runsTestForRandomnessPresenter = new RunsTestForRandomnessPresenter(dataSetManagerPresenter);
            forecastPresenter = new ForecastPresenter(dataSetManagerPresenter);

            // Add Event Handlers for the click events of the buttons.
            btnDataSetManager.Click += delegate { dataSetManagerPresenter.openDataSetManager(); };
            btnLag.Click += delegate { lagPresenter.openView(); };
            btnDummy.Click += delegate { dummyPresenter.openView(); };
            btnOneVariableSummary.Click += delegate { oneVariableSummaryPresenter.openView(); };
            btnCorrelationAndCovariance.Click += delegate { correlationCovarianceForm = correlationCovarianceForm.createAndOrShowForm(); };
            btnHistogram.Click += delegate { histogramPresenter.openView(); };
            btnScatterplot.Click += delegate { scatterPlotPresenter.openView(); };
            btnBoxWhiskerPlot.Click += delegate { boxWhiskerPlotPresenter.openView(); };
            btnSampleSizeEstimation.Click += delegate { sampleSizeEstimationPresenter.openView(); };
            btnRunsTestForRandomness.Click += delegate { runsTestForRandomnessPresenter.openView(); };
            btnForecast.Click += delegate { forecastPresenter.openView(); };
            btnLogisticRegression.Click += delegate { logisticRegressionForm = logisticRegressionForm.createAndOrShowForm(); };
            btnDiscriminantAnalysis.Click += delegate { discriminantAnalysisForm = discriminantAnalysisForm.createAndOrShowForm(); };
            btnXRChart.Click += delegate { xrChartPresenter.openView(); };
            btnPChart.Click += delegate { pChartPresenter.openView(); };
            btnProcessCapability.Click += delegate { processCapabilityPresenter.openView(); };
            btnTimeSeriesGraph.Click += delegate { timeSeriesGraphPresenter.openView(); };
            btnSimpleRegression.Click += delegate { regressionForm = regressionForm.createAndOrShowForm(); };
        }
    }
}