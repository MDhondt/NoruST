using Microsoft.Office.Tools.Ribbon;
using NoruST.Data;
using NoruST.Forms;

namespace NoruST
{
    /// <summary>
    /// <para>Ribbon.</para>
    /// <para>Version: 2.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 26, 2016</para>
    /// </summary>
    public partial class Ribbon
    {
        #region Fields

        private DataSetManager _dataSetManager;
        private LagForm _lagForm;
        private DummyForm _dummyForm;
        private OneVariableSummaryForm _oneVariableSummaryForm;
        private CorrelationCovarianceForm _correlationCovarianceForm;
        private HistogramForm _histogramForm;
        private ScatterplotForm _scatterplotForm;
        private BoxWhiskerPlotForm _boxWhiskerPlotForm;
        private ConfidenceIntervalMeanAndStandardDeviationForm _confidenceIntervalMeanAndStandardDeviationForm;
        private SampleSizeEstimationForm _sampleSizeSelectionForm;
        private TimeSeriesGraphForm _timeSeriesGraphForm;
        private RunsTestForRandomnessForm _runsTestForRandomnessForm;
        private ForecastForm _forecastForm;
        private RegressionForm _regressionForm;
        private LogisticRegressionForm _logisticRegressionForm;
        private DiscriminantAnalysisForm _discriminantAnalysisForm;

        #endregion

        #region Loading

        /// <summary>
        /// Fires when the Ribbon is loading.
        /// </summary>
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            // Initialize the required classes to work.
            _dataSetManager = new DataSetManager();

            // Add Event Handlers for the click events of the buttons.
            btnDataSetManager.Click += delegate { _dataSetManager.NewDataSet(); };
            btnLag.Click += delegate { _lagForm = _lagForm.ShowForm(); };
            btnDummy.Click += delegate { _dummyForm = _dummyForm.ShowForm(); };
            btnOneVariableSummary.Click += delegate { _oneVariableSummaryForm = _oneVariableSummaryForm.ShowForm(); };
            btnCorrelationAndCovariance.Click += delegate { _correlationCovarianceForm = _correlationCovarianceForm.ShowForm(); };
            btnHistogram.Click += delegate { _histogramForm = _histogramForm.ShowForm(); };
            btnScatterplot.Click += delegate { _scatterplotForm = _scatterplotForm.ShowForm(); };
            btnBoxWhiskerPlot.Click += delegate { _boxWhiskerPlotForm = _boxWhiskerPlotForm.ShowForm(); };
            btnConfidenceIntervalMeanAndStandardDeviation.Click += delegate { _confidenceIntervalMeanAndStandardDeviationForm = _confidenceIntervalMeanAndStandardDeviationForm.ShowForm(); };
            btnSampleSizeEstimation.Click += delegate { _sampleSizeSelectionForm = _sampleSizeSelectionForm.ShowForm(); };
            btnTimeSeriesGraph.Click += delegate { _timeSeriesGraphForm = _timeSeriesGraphForm.ShowForm(); };
            btnRunsTestForRandomness.Click += delegate { _runsTestForRandomnessForm = _runsTestForRandomnessForm.ShowForm(); };
            btnForecast.Click += delegate { _forecastForm = _forecastForm.ShowForm(); };
            btnRegression.Click += delegate { _regressionForm = _regressionForm.ShowForm(); };
            btnLogisticRegression.Click += delegate { _logisticRegressionForm = _logisticRegressionForm.ShowForm(); };
            btnDiscriminantAnalysis.Click += delegate { _discriminantAnalysisForm = _discriminantAnalysisForm.ShowForm(); };
        }

        #endregion
    }
}