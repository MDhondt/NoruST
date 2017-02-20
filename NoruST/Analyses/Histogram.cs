using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using NoruST.Models;

namespace NoruST.Analyses
{  
    /// <summary>
     /// <para>Histogram.</para>
     /// <para>Version: 1.0</para>
     /// <para>&#160;</para>
     /// <para>Author: Frederik Van de Velde</para>
     /// <para>&#160;</para>
     /// <para>Last Updated: Apr 23, 2016</para>
     /// </summary>
    public class Histogram
    {
        #region Fields

        private _Worksheet _sheet;
        private readonly SummaryStatisticsBool _summaryBool = new SummaryStatisticsBool(histogram: true);
        private List<Models.Data> _valuesArray;
        private int _row;
        private int _counter;

        #endregion

        #region Public Methods

        /// <summary>
        /// Create a new <see cref="Chart"/> and add it to a new <see cref="_Worksheet"/> in the same <see cref="Workbook"/>.
        /// </summary>
        /// <param name="dataSet">The <see cref="DataSet"/> source for the <see cref="Chart"/>.</param>   
        /// <param name="doIncludeCategory">A <see cref="List{T}"/> of <see cref="bool"/>s that corresponds to which <see cref="Models.Data"/> in the <see cref="DataSet.DataList"/> should be included as the category.</param>
        /// <param name="doIncludeValue">A <see cref="List{T}"/> of <see cref="bool"/>s that corresponds to which <see cref="Models.Data"/> in the <see cref="DataSet.DataList"/> should be included as the value.</param>
        /// <param name="isFixedNumberOfBins">Indicates if the number of bins are fixed (true) or automatically generated (false).</param>
        /// <param name="numberOfBins">If a fixed number of bins, this is the value.</param>
        /// <param name="row">(Optional) The first row the data will be written to. Default is 1.</param>
        /// <param name="column">(Optional) The first column the data will be written to. Default is 1.</param>
        public bool CreateChart(DataSet dataSet, List<bool> doIncludeCategory, List<bool> doIncludeValue, bool isFixedNumberOfBins, int numberOfBins, int row = 1, int column = 1)
        {
            // Check the input so everything is working like intended.
            var check = new CheckInput(dataSet, "Histogram", doIncludeCategory, DefaultCheck.Nonnumeric, -1, doIncludeValue, DefaultCheck.Numeric, 1, _summaryBool, isCategory: true);
            if (!check.Successful) return false;
            var categories = check.Categories;
            _valuesArray = check.Values;

            // Create a new sheet for the chart(s).
            _sheet = WorksheetHelper.NewWorksheet("Histogram");

            // Create a new DataSet.
            dataSet = DataSet.GetByCategories(_sheet, categories[0], _valuesArray, row, column + 1);

            // Create an array that holds the Sets of Data that need a Summary Statistic.
            _valuesArray = dataSet.DataList;

            // Calculate where the first data should come.
            var dataRows = _counter = (int)Math.Ceiling((dataSet.Range.Row + dataSet.Range.Rows.Count) / 15.0);
            _row = 15 * _counter;

            // Create the Histogram.
            foreach (var data in _valuesArray)
            {
                PrintCategories(column);
                PrintVariables(data, column, isFixedNumberOfBins, numberOfBins);

                if (_row < 15 * _counter)
                    _row = 15 * _counter;
            }

            // Hide the unnecessary data.
            _sheet.Range[row + ":" + (dataRows * 15 - 1)].EntireRow.Hidden = true;

            return true;
        }

        /// <summary>
        /// Create a new <see cref="Chart"/> and add it to a new <see cref="_Worksheet"/> in the same <see cref="Workbook"/>.
        /// </summary>
        /// <param name="dataSet">The <see cref="DataSet"/> source for the <see cref="Chart"/>.</param>
        /// <param name="doInclude">A <see cref="List{T}"/> of <see cref="bool"/>s that corresponds to which <see cref="Models.Data"/> in the <see cref="DataSet.DataList"/> should be included.</param>
        /// <param name="isFixedNumberOfBins">Indicates if the number of bins are fixed (true) or automatically generated (false).</param>
        /// <param name="numberOfBins">If a fixed number of bins, this is the value.</param>
        /// <param name="row">(Optional) The first row the data will be written to. Default is 1.</param>
        /// <param name="column">(Optional) The first column the data will be written to. Default is 1.</param>
        public bool CreateChart(DataSet dataSet, List<bool> doInclude, bool isFixedNumberOfBins, int numberOfBins, int row = 1, int column = 1)
        {
            // Check the input so everything is working like intended.
            var check = new CheckInput(dataSet, "Histogram", doInclude, DefaultCheck.Numeric, doCalculate: new SummaryStatisticsBool(minimum: true, maximum: true));
            if (!check.Successful) return false;
            _valuesArray = check.Values;

            // Create a new sheet for the chart(s).
            _sheet = WorksheetHelper.NewWorksheet("Histogram");
            _row = row;

            // Create the Histogram.
            foreach (var data in _valuesArray)
            {
                PrintCategories(column);
                PrintVariables(data, column, isFixedNumberOfBins, numberOfBins);

                if (_row < 15 * _counter)
                    _row = 15 * _counter;
            }

            return true;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Print the categories to the <see cref="_Worksheet"/>.
        /// </summary>
        /// <param name="firstColumn">The 1st column.</param>
        private void PrintCategories(int firstColumn)
        {
            var column = firstColumn;
            _sheet.Cells[_row, column++] = "Histogram";
            _sheet.Cells[_row, column++] = "Bin Min.";
            _sheet.Cells[_row, column++] = "Bin Max.";
            _sheet.Cells[_row, column++] = "Bin Midpoint";
            _sheet.Cells[_row, column++] = "Freq.";
            _sheet.Cells[_row, column++] = "Rel. Freq.";
            _sheet.Cells[_row, column] = "Prb. Density";
            _row++;
        }

        /// <summary>
        /// Create a new <see cref="Chart"/> and add it to a new <see cref="Worksheet"/> in the same <see cref="Workbook"/>.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="firstColumn">The 1st column.</param>
        /// <param name="isFixedNumberOfBins">Indicates if the number of bins are fixed (true) or automatically generated (false).</param>
        /// <param name="numberOfBins">If a fixed number of bins, this is the value.</param>
        private void PrintVariables(Models.Data data, int firstColumn, bool isFixedNumberOfBins, int numberOfBins)
        {
            // Calculate the Summary Statistics.
            var summary = isFixedNumberOfBins ? new SummaryStatistics(data.Range, _summaryBool, numberOfBins: numberOfBins) : new SummaryStatistics(data.Range, _summaryBool);

            // Write the needed data to the sheet.
            for (var bin = 0; bin < summary.NumberOfBins; bin++)
            {
                var column = firstColumn;
                _sheet.Cells[_row, column++] = "Bin #" + bin;
                _sheet.WriteFunction(_row, column, bin == 0 ? summary.Minimum : AddressConverter.CellAddress(_row - 1, column + 1)); column++;
                _sheet.WriteFunction(_row, column, AddressConverter.CellAddress(_row, column - 1) + "+" + summary.BinRange); column++;
                _sheet.Cells[_row, column] = "=(" + AddressConverter.CellAddress(_row, column - 2) + "+" + AddressConverter.CellAddress(_row, column - 1) + ")/2"; column++;
                _sheet.WriteFunction(_row, column, "COUNTIF(" + data.RangeName.Name + ",\"<=\"&" + AddressConverter.CellAddress(_row, column - 2) + ")-COUNTIF(" + data.RangeName.Name + ",\"<\"&" + AddressConverter.CellAddress(_row, column - 3) + ")"); column++;
                _sheet.WriteFunction(_row, column, AddressConverter.CellAddress(_row, column - 1) + "/" + summary.Count); column++;
                _sheet.WriteFunction(_row, column, AddressConverter.CellAddress(_row, column - 1) + "/" + summary.BinRange);
                _row++;
            }

            // Create the chart.
            var charts = (ChartObjects)_sheet.ChartObjects();
            var chartObject = charts.Add(400, 225 * _counter, 100 * summary.NumberOfBins, 200);
            var chart = chartObject.Chart;
            chart.ChartType = XlChartType.xlColumnClustered;
            chart.ChartWizard(Title: "Histogram - " + data.Name, HasLegend: false);
            var seriesCollection = (SeriesCollection)chart.SeriesCollection();

            var series = seriesCollection.Add(_sheet.Range[_sheet.Cells[_row - summary.NumberOfBins, firstColumn + 4], _sheet.Cells[_row - 1, firstColumn + 4]]);
            series.ChartType = XlChartType.xlColumnClustered;
            series.XValues = _sheet.Range[_sheet.Cells[_row - summary.NumberOfBins, firstColumn + 3], _sheet.Cells[_row - 1, firstColumn + 3]];

            _counter++;
        }

        #endregion
    }
}