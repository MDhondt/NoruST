using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using NoruST.Models;

namespace NoruST.Analyses
{
    /// <summary>
    /// <para>Box - Whisker Plot.</para>
    /// <para>Version: 4.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 18, 2016</para>
    /// </summary>
    public class BoxWhiskerPlot
    {
        #region Public Methods

        public bool CreateChart(DataSet dataSet, List<bool> doIncludeCategory, List<bool> doIncludeValue)
        {
            // Print the Summary Statistics to the sheet.
            var summary = new OneVariableSummary();
            if (!summary.Print(dataSet, doIncludeCategory, doIncludeValue, new SummaryStatisticsBool(boxWhiskerPlot: true), sheetName: "Box-Whisker Plot")) return false;

            // Create the Box-Whisker Plot.
            Create(summary);

            return true;
        }

        /// <summary>
        /// Create a new <see cref="Chart"/> and add it to a new <see cref="_Worksheet"/> in the same <see cref="Workbook"/>.
        /// </summary>
        /// <param name="dataSet">The <see cref="DataSet"/> source for the <see cref="Chart"/>.</param>
        /// <param name="doInclude">A <see cref="List{T}"/> of <see cref="bool"/>s that corresponds to which <see cref="Models.Data"/> in the <see cref="DataSet.DataList"/> should be included.</param>
        public bool CreateChart(DataSet dataSet, List<bool> doInclude)
        {
            // Print the Summary Statistics to the sheet.
            var summary = new OneVariableSummary();
            if (!summary.Print(dataSet, doInclude, new SummaryStatisticsBool(boxWhiskerPlot: true), sheetName: "Box-Whisker Plot")) return false;

            // Create the Box-Whisker Plot.
            Create(summary);

            return true;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Create a new <see cref="Chart"/> and add it to a new <see cref="Worksheet"/> in the same <see cref="Workbook"/>.
        /// </summary>
        /// <param name="summary">The Summary Statistics needed to create the <see cref="Chart"/>.</param>
        private static void Create(OneVariableSummary summary)
        {
            // Create an array that holds the secondary Y-Axis values. The secondary Y-Axis will have a max. value of 1 (see later). These values are only needed to display the mean and outliers properly on the chart.
            var yValues = new List<double>();

            // To center the mean and outliers, the secondary Y-Axis has to be divided in sections. Each Box-Whisker Plot has a section above and below so if 1 Box-Whisker Plot is needed, the dots will be at 50% of the max. secondary Y-Axis value. If 2 Box-Whisker Plots are needed, the dots will be at 25% for the 1st and 75% for the 2nd of the max. secondary Y-Axis value. 
            var section = 1.0 / (2 * summary.ValuesArray.Count);
            for (var i = 0; i < summary.ValuesArray.Count; i++)
                yValues.Add((2 * (i + 1) - 1) * section);

            // Create the chart.
            var charts = (ChartObjects)summary.Sheet.ChartObjects();
            var chartObject = charts.Add(0, 0, 500, 125 * summary.ValuesArray.Count);
            var chart = chartObject.Chart;
            chart.ChartType = XlChartType.xlBarStacked;
            chart.ChartWizard(Title: "Box-Whisker Plot", HasLegend: false);
            var seriesCollection = (SeriesCollection)chart.SeriesCollection();

            // Add the Quartile 1 to the chart.
            var series = seriesCollection.Add(summary.Sheet.Range[summary.Sheet.Cells[summary.Quartile1Row, summary.FirstValuesColumn], summary.Sheet.Cells[summary.Quartile1Row, summary.ValuesArray.Count + 1]]);
            series.ChartType = XlChartType.xlBarStacked;
            series.Format.Fill.Solid();
            series.Format.Fill.Transparency = 1;

            // Add the lower halve to the chart.
            series = seriesCollection.Add(summary.Sheet.Range[summary.Sheet.Cells[summary.Quartile1MedianRow, summary.FirstValuesColumn], summary.Sheet.Cells[summary.Quartile1MedianRow, summary.ValuesArray.Count + 1]]);
            series.ChartType = XlChartType.xlBarStacked;
            series.Format.Fill.Solid();
            series.Format.Fill.Transparency = 1;
            series.Border.LineStyle = XlLineStyle.xlContinuous;
            series.Format.Line.Weight = 1.5f;

            // Add the upper halve to the chart.
            series = seriesCollection.Add(summary.Sheet.Range[summary.Sheet.Cells[summary.MedianQuartile3Row, summary.FirstValuesColumn], summary.Sheet.Cells[summary.MedianQuartile3Row, summary.ValuesArray.Count + 1]]);
            series.ChartType = XlChartType.xlBarStacked;
            series.Format.Fill.Solid();
            series.Format.Fill.Transparency = 1;
            series.Border.LineStyle = XlLineStyle.xlContinuous;
            series.Format.Line.Weight = 1.5f;

            // Set the Categories Axis.
            ((Axis)chart.Axes(XlAxisType.xlCategory)).CategoryNames = summary.Sheet.Range[summary.Sheet.Cells[summary.HeaderRow, summary.FirstValuesColumn], summary.Sheet.Cells[summary.HeaderRow, summary.ValuesArray.Count + 1]];

            // Add both the minus and plus whiskers to the chart.
            ((Series)chart.SeriesCollection(1)).ErrorBar(XlErrorBarDirection.xlY, XlErrorBarInclude.xlErrorBarIncludeMinusValues, XlErrorBarType.xlErrorBarTypeCustom, 0, summary.Sheet.Range[summary.Sheet.Cells[summary.MinusWhiskerRow, summary.FirstValuesColumn], summary.Sheet.Cells[summary.MinusWhiskerRow, summary.ValuesArray.Count + 1]]);
            ((Series)chart.SeriesCollection(1)).ErrorBars.Format.Line.Weight = 1.5f;
            ((Series)chart.SeriesCollection(3)).ErrorBar(XlErrorBarDirection.xlY, XlErrorBarInclude.xlErrorBarIncludePlusValues, XlErrorBarType.xlErrorBarTypeCustom, summary.Sheet.Range[summary.Sheet.Cells[summary.PlusWhiskerRow, summary.FirstValuesColumn], summary.Sheet.Cells[summary.PlusWhiskerRow, summary.ValuesArray.Count + 1]], 0);
            ((Series)chart.SeriesCollection(3)).ErrorBars.Format.Line.Weight = 1.5f;

            // Add the means to the chart as a Scatterplot and change the layout.
            series = seriesCollection.Add();
            series.ChartType = XlChartType.xlXYScatter;
            series.Name = "Mean";
            series.Values = yValues.ToArray();
            series.XValues = summary.Sheet.Range[summary.Sheet.Cells[summary.MeanRow, summary.FirstValuesColumn], summary.Sheet.Cells[summary.MeanRow, summary.ValuesArray.Count + 1]];
            series.MarkerStyle = XlMarkerStyle.xlMarkerStyleX;
            series.MarkerForegroundColor = (int)XlRgbColor.rgbDarkBlue;

            // Add all the outliers to the chart as a Scatterplot and change the layout.
            var row = 0;
            while (row < summary.OutliersRow.Count)
            {
                series = seriesCollection.Add();
                series.ChartType = XlChartType.xlXYScatter;
                series.Name = "Outliers";
                series.Values = yValues.ToArray();
                series.XValues = summary.Sheet.Range[summary.Sheet.Cells[summary.OutliersRow[row], summary.FirstValuesColumn], summary.Sheet.Cells[summary.OutliersRow[row], summary.ValuesArray.Count + 1]];
                series.MarkerStyle = XlMarkerStyle.xlMarkerStyleSquare;
                series.MarkerBackgroundColor = (int)XlRgbColor.rgbDarkRed;
                series.MarkerForegroundColor = (int)XlRgbColor.rgbDarkRed;

                row++;
            }

            // Hide the secondary axis and set max value.
            ((Axis)chart.Axes(XlAxisType.xlValue, XlAxisGroup.xlSecondary)).MaximumScale = 1;
            chart.HasAxis[XlAxisType.xlValue, XlAxisGroup.xlSecondary] = false;
        }

        #endregion
    }
}