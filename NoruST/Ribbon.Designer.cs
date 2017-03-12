namespace NoruST
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabNoruST = this.Factory.CreateRibbonTab();
            this.grpData = this.Factory.CreateRibbonGroup();
            this.btnDataSetManager = this.Factory.CreateRibbonButton();
            this.btnDataViewer = this.Factory.CreateRibbonButton();
            this.btnDataUtilities = this.Factory.CreateRibbonMenu();
            this.btnDummy = this.Factory.CreateRibbonButton();
            this.btnLag = this.Factory.CreateRibbonButton();
            this.grpAnalyses = this.Factory.CreateRibbonGroup();
            this.menuSummaryStatistics = this.Factory.CreateRibbonMenu();
            this.btnOneVariableSummary = this.Factory.CreateRibbonButton();
            this.btnCorrelationAndCovariance = this.Factory.CreateRibbonButton();
            this.menuSummaryGraphs = this.Factory.CreateRibbonMenu();
            this.btnHistogram = this.Factory.CreateRibbonButton();
            this.btnScatterplot = this.Factory.CreateRibbonButton();
            this.btnBoxWhiskerPlot = this.Factory.CreateRibbonButton();
            this.menuStatisticalInference = this.Factory.CreateRibbonMenu();
            this.btnConfidenceIntervalMeanAndStandardDeviation = this.Factory.CreateRibbonButton();
            this.btnSampleSizeEstimation = this.Factory.CreateRibbonButton();
            this.menuTimeSeriesAndForecasting = this.Factory.CreateRibbonMenu();
            this.btnTimeSeriesGraph = this.Factory.CreateRibbonButton();
            this.btnRunsTestForRandomness = this.Factory.CreateRibbonButton();
            this.btnForecast = this.Factory.CreateRibbonButton();
            this.menuRegressionAndClassification = this.Factory.CreateRibbonMenu();
            this.btnRegression = this.Factory.CreateRibbonButton();
            this.btnLogisticRegression = this.Factory.CreateRibbonButton();
            this.btnDiscriminantAnalysis = this.Factory.CreateRibbonButton();
            this.grpHelp = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.tabNoruST.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpAnalyses.SuspendLayout();
            this.grpHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNoruST
            // 
            this.tabNoruST.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabNoruST.Groups.Add(this.grpData);
            this.tabNoruST.Groups.Add(this.grpAnalyses);
            this.tabNoruST.Groups.Add(this.grpHelp);
            this.tabNoruST.Label = "NoruST";
            this.tabNoruST.Name = "tabNoruST";
            // 
            // grpData
            // 
            this.grpData.Items.Add(this.btnDataSetManager);
            this.grpData.Items.Add(this.btnDataViewer);
            this.grpData.Items.Add(this.btnDataUtilities);
            this.grpData.Label = "Data";
            this.grpData.Name = "grpData";
            // 
            // btnDataSetManager
            // 
            this.btnDataSetManager.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDataSetManager.Label = "Data Set Manager";
            this.btnDataSetManager.Name = "btnDataSetManager";
            this.btnDataSetManager.ShowImage = true;
            // 
            // btnDataViewer
            // 
            this.btnDataViewer.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDataViewer.Label = "Data Viewer";
            this.btnDataViewer.Name = "btnDataViewer";
            this.btnDataViewer.ShowImage = true;
            this.btnDataViewer.Visible = false;
            // 
            // btnDataUtilities
            // 
            this.btnDataUtilities.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDataUtilities.Items.Add(this.btnDummy);
            this.btnDataUtilities.Items.Add(this.btnLag);
            this.btnDataUtilities.Label = "Data Utilities";
            this.btnDataUtilities.Name = "btnDataUtilities";
            this.btnDataUtilities.ShowImage = true;
            // 
            // btnDummy
            // 
            this.btnDummy.Label = "Dummy";
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.ShowImage = true;
            // 
            // btnLag
            // 
            this.btnLag.Label = "Lag";
            this.btnLag.Name = "btnLag";
            this.btnLag.ShowImage = true;
            // 
            // grpAnalyses
            // 
            this.grpAnalyses.Items.Add(this.menuSummaryStatistics);
            this.grpAnalyses.Items.Add(this.menuSummaryGraphs);
            this.grpAnalyses.Items.Add(this.menuStatisticalInference);
            this.grpAnalyses.Items.Add(this.menuTimeSeriesAndForecasting);
            this.grpAnalyses.Items.Add(this.menuRegressionAndClassification);
            this.grpAnalyses.Label = "Analyses";
            this.grpAnalyses.Name = "grpAnalyses";
            // 
            // menuSummaryStatistics
            // 
            this.menuSummaryStatistics.Items.Add(this.btnOneVariableSummary);
            this.menuSummaryStatistics.Items.Add(this.btnCorrelationAndCovariance);
            this.menuSummaryStatistics.Label = "Summary Statistics";
            this.menuSummaryStatistics.Name = "menuSummaryStatistics";
            // 
            // btnOneVariableSummary
            // 
            this.btnOneVariableSummary.Label = "One-Variable Summary";
            this.btnOneVariableSummary.Name = "btnOneVariableSummary";
            this.btnOneVariableSummary.ShowImage = true;
            // 
            // btnCorrelationAndCovariance
            // 
            this.btnCorrelationAndCovariance.Label = "Correlation and Covariance";
            this.btnCorrelationAndCovariance.Name = "btnCorrelationAndCovariance";
            this.btnCorrelationAndCovariance.ShowImage = true;
            // 
            // menuSummaryGraphs
            // 
            this.menuSummaryGraphs.Items.Add(this.btnHistogram);
            this.menuSummaryGraphs.Items.Add(this.btnScatterplot);
            this.menuSummaryGraphs.Items.Add(this.btnBoxWhiskerPlot);
            this.menuSummaryGraphs.Label = "Summary Graphs";
            this.menuSummaryGraphs.Name = "menuSummaryGraphs";
            // 
            // btnHistogram
            // 
            this.btnHistogram.Label = "Histogram";
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.ShowImage = true;
            // 
            // btnScatterplot
            // 
            this.btnScatterplot.Image = global::NoruST.Properties.Resources.scatter_plot_512;
            this.btnScatterplot.Label = "Scatterplot";
            this.btnScatterplot.Name = "btnScatterplot";
            this.btnScatterplot.ShowImage = true;
            // 
            // btnBoxWhiskerPlot
            // 
            this.btnBoxWhiskerPlot.Label = "Box-Whisker Plot";
            this.btnBoxWhiskerPlot.Name = "btnBoxWhiskerPlot";
            this.btnBoxWhiskerPlot.ShowImage = true;
            // 
            // menuStatisticalInference
            // 
            this.menuStatisticalInference.Items.Add(this.btnConfidenceIntervalMeanAndStandardDeviation);
            this.menuStatisticalInference.Items.Add(this.btnSampleSizeEstimation);
            this.menuStatisticalInference.Label = "Statistical Inference";
            this.menuStatisticalInference.Name = "menuStatisticalInference";
            // 
            // btnConfidenceIntervalMeanAndStandardDeviation
            // 
            this.btnConfidenceIntervalMeanAndStandardDeviation.Label = "Confidence Interval - Mean and Standard Deviation";
            this.btnConfidenceIntervalMeanAndStandardDeviation.Name = "btnConfidenceIntervalMeanAndStandardDeviation";
            this.btnConfidenceIntervalMeanAndStandardDeviation.ShowImage = true;
            // 
            // btnSampleSizeEstimation
            // 
            this.btnSampleSizeEstimation.Label = "Sample Size Estimation";
            this.btnSampleSizeEstimation.Name = "btnSampleSizeEstimation";
            this.btnSampleSizeEstimation.ShowImage = true;
            // 
            // menuTimeSeriesAndForecasting
            // 
            this.menuTimeSeriesAndForecasting.Items.Add(this.btnTimeSeriesGraph);
            this.menuTimeSeriesAndForecasting.Items.Add(this.btnRunsTestForRandomness);
            this.menuTimeSeriesAndForecasting.Items.Add(this.btnForecast);
            this.menuTimeSeriesAndForecasting.Label = "Time Series and Forecasting";
            this.menuTimeSeriesAndForecasting.Name = "menuTimeSeriesAndForecasting";
            // 
            // btnTimeSeriesGraph
            // 
            this.btnTimeSeriesGraph.Label = "Time Series Graph";
            this.btnTimeSeriesGraph.Name = "btnTimeSeriesGraph";
            this.btnTimeSeriesGraph.ShowImage = true;
            // 
            // btnRunsTestForRandomness
            // 
            this.btnRunsTestForRandomness.Label = "Runs Test for Randomness";
            this.btnRunsTestForRandomness.Name = "btnRunsTestForRandomness";
            this.btnRunsTestForRandomness.ShowImage = true;
            // 
            // btnForecast
            // 
            this.btnForecast.Label = "Forecast";
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.ShowImage = true;
            // 
            // menuRegressionAndClassification
            // 
            this.menuRegressionAndClassification.Items.Add(this.btnRegression);
            this.menuRegressionAndClassification.Items.Add(this.btnLogisticRegression);
            this.menuRegressionAndClassification.Items.Add(this.btnDiscriminantAnalysis);
            this.menuRegressionAndClassification.Label = "Regression and Classification";
            this.menuRegressionAndClassification.Name = "menuRegressionAndClassification";
            // 
            // btnRegression
            // 
            this.btnRegression.Label = "Regression";
            this.btnRegression.Name = "btnRegression";
            this.btnRegression.ShowImage = true;
            // 
            // btnLogisticRegression
            // 
            this.btnLogisticRegression.Label = "Logistic Regression";
            this.btnLogisticRegression.Name = "btnLogisticRegression";
            this.btnLogisticRegression.ShowImage = true;
            // 
            // btnDiscriminantAnalysis
            // 
            this.btnDiscriminantAnalysis.Label = "Discriminant Analysis";
            this.btnDiscriminantAnalysis.Name = "btnDiscriminantAnalysis";
            this.btnDiscriminantAnalysis.ShowImage = true;
            // 
            // grpHelp
            // 
            this.grpHelp.Items.Add(this.button1);
            this.grpHelp.Label = "Help";
            this.grpHelp.Name = "grpHelp";
            this.grpHelp.Visible = false;
            // 
            // button1
            // 
            this.button1.Label = "";
            this.button1.Name = "button1";
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabNoruST);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tabNoruST.ResumeLayout(false);
            this.tabNoruST.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpAnalyses.ResumeLayout(false);
            this.grpAnalyses.PerformLayout();
            this.grpHelp.ResumeLayout(false);
            this.grpHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabNoruST;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDataSetManager;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDataViewer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpAnalyses;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpHelp;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuSummaryGraphs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnBoxWhiskerPlot;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnScatterplot;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuSummaryStatistics;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOneVariableSummary;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCorrelationAndCovariance;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDummy;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLag;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu btnDataUtilities;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuStatisticalInference;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConfidenceIntervalMeanAndStandardDeviation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSampleSizeEstimation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHistogram;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuRegressionAndClassification;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDiscriminantAnalysis;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRegression;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuTimeSeriesAndForecasting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRunsTestForRandomness;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogisticRegression;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTimeSeriesGraph;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnForecast;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
