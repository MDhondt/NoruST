using Microsoft.Office.Tools.Ribbon;
using NoruST.Data;
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
        private DummyForm dummyForm;
        private OneVariableSummaryForm oneVariableSummaryForm;
        private CorrelationCovarianceForm correlationCovarianceForm;
        private HistogramForm histogramForm;
        private ScatterplotForm scatterplotForm;
        private BoxWhiskerPlotForm boxWhiskerPlotForm;
        private ConfidenceIntervalMeanAndStandardDeviationForm confidenceIntervalMeanAndStandardDeviationForm;
        private SampleSizeEstimationForm sampleSizeSelectionForm;
        private TimeSeriesGraphForm timeSeriesGraphForm;
        private RunsTestForRandomnessForm runsTestForRandomnessForm;
        private ForecastForm forecastForm;
        private RegressionForm regressionForm;
        private LogisticRegressionForm logisticRegressionForm;
        private DiscriminantAnalysisForm discriminantAnalysisForm;
        private XRChartForm xRChartForm;
        private PChartForm pChartForm;

        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            // Initialize the required classes to work.
            dataSetManagerPresenter = new DataSetManagerPresenter();
            lagPresenter = new LagPresenter(dataSetManagerPresenter);
            xrChartPresenter = new XRChartPresenter(dataSetManagerPresenter);
            pChartPresenter = new PChartPresenter(dataSetManagerPresenter);

            // Add Event Handlers for the click events of the buttons.
            btnDataSetManager.Click += delegate { dataSetManagerPresenter.openDataSetManager(); };
            btnLag.Click += delegate { lagPresenter.openView(); };
            btnDummy.Click += delegate { dummyForm = dummyForm.createAndOrShowForm(); };
            btnOneVariableSummary.Click += delegate { oneVariableSummaryForm = oneVariableSummaryForm.createAndOrShowForm(); };
            btnCorrelationAndCovariance.Click += delegate { correlationCovarianceForm = correlationCovarianceForm.createAndOrShowForm(); };
            btnHistogram.Click += delegate { histogramForm = histogramForm.createAndOrShowForm(); };
            btnScatterplot.Click += delegate { scatterplotForm = scatterplotForm.createAndOrShowForm(); };
            btnBoxWhiskerPlot.Click += delegate { boxWhiskerPlotForm = boxWhiskerPlotForm.createAndOrShowForm(); };
            btnConfidenceIntervalMeanAndStandardDeviation.Click += delegate { confidenceIntervalMeanAndStandardDeviationForm = confidenceIntervalMeanAndStandardDeviationForm.createAndOrShowForm(); };
            btnSampleSizeEstimation.Click += delegate { sampleSizeSelectionForm = sampleSizeSelectionForm.createAndOrShowForm(); };
            btnTimeSeriesGraph.Click += delegate { timeSeriesGraphForm = timeSeriesGraphForm.createAndOrShowForm(); };
            btnRunsTestForRandomness.Click += delegate { runsTestForRandomnessForm = runsTestForRandomnessForm.createAndOrShowForm(); };
            btnForecast.Click += delegate { forecastForm = forecastForm.createAndOrShowForm(); };
            btnLogisticRegression.Click += delegate { logisticRegressionForm = logisticRegressionForm.createAndOrShowForm(); };
            btnDiscriminantAnalysis.Click += delegate { discriminantAnalysisForm = discriminantAnalysisForm.createAndOrShowForm(); };
            btnXRChart.Click += delegate { xrChartPresenter.openView(); };
            btnPChart.Click += delegate { pChartPresenter.openView(); };
        }

        private void btnConfidenceIntervalMeanAndStandardDeviation_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}