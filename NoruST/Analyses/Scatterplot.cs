using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using NoruST.Models;

namespace NoruST.Analyses
{
    /// <summary>
    /// <para>Scatterplot.</para>
    /// <para>Version: 2.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 18, 2016</para>
    /// </summary>
    public class Scatterplot
    {
        #region Public Methods

        /// <summary>
        /// Create a new <see cref="Chart"/> and add it to a new <see cref="_Worksheet"/> in the same <see cref="_Workbook"/>.
        /// </summary>
        /// <param name="dataSet">The <see cref="DataSet"/> which needs (a) Scatterplot(s).</param>
        /// <param name="doIncludeX">A <see cref="List{T}"/> of <see cref="bool"/>s that corresponds to which <see cref="Models.Data"/> in the <see cref="DataSet.DataList"/> should be included for X.</param>
        /// <param name="doIncludeY">A <see cref="List{T}"/> of <see cref="bool"/>s that corresponds to which <see cref="Models.Data"/> in the <see cref="DataSet.DataList"/> should be included for Y.</param>
        public bool CreateChart(DataSet dataSet, List<bool> doIncludeX, List<bool> doIncludeY)
        {
            // Check the input so everything is working like intended.
            var check = new CheckInput(dataSet, "Scatterplot", doIncludeX, DefaultCheck.Numeric, 1, doIncludeY, DefaultCheck.Numeric, 1);
            if (!check.Successful) return false;

            // Create a new sheet for the chart.
            var sheet = WorksheetHelper.NewWorksheet("Scatterplot");

            // Initialize the Y offset.
            var offsetY = 0;

            // Do the following code for each check in X.
            for (var x = 0; x < doIncludeX.Count; x++)
            {
                // Check if the X is checked.
                if (!doIncludeX[x]) continue;

                // Initialize the X offset.
                var offsetX = 0;

                // Do the following code for each check in Y.
                for (var y = 0; y < doIncludeY.Count; y++)
                {
                    // Check if Y is checked.
                    if (!doIncludeY[y]) continue;

                    // Create the chart.
                    var charts = (ChartObjects)sheet.ChartObjects();
                    var chartObject = charts.Add(offsetX * 300, offsetY * 200, 300, 200);
                    var chart = chartObject.Chart;
                    chart.ChartType = XlChartType.xlXYScatter;
                    chart.ChartWizard(Title: "Scatterplot " + dataSet.DataList[x].Name + " vs " + dataSet.DataList[y].Name, HasLegend: false);
                    var seriesCollection = (SeriesCollection)chart.SeriesCollection();

                    // Add the points and change the layout.
                    var series = seriesCollection.Add();
                    series.Values = dataSet.DataList[y].Range;
                    series.XValues = dataSet.DataList[x].Range;
                    series.MarkerStyle = XlMarkerStyle.xlMarkerStyleCircle;

                    // Increment the X offset by 1.
                    offsetX++;
                }

                // Increment the Y offset by 1.
                offsetY++;
            }

            return true;
        }

        #endregion
    }
}