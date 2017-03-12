using System;
using System.Collections.Generic;
using NoruST.Models;

// ReSharper disable LoopCanBePartlyConvertedToQuery
// ReSharper disable LoopCanBeConvertedToQuery
// ReSharper disable LocalizableElement
// ReSharper disable SwitchStatementMissingSomeCases

namespace NoruST.Data
{
    /// <summary>
    /// <para>Dummy & Lag.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 18, 2016</para>
    /// </summary>
    public class DummyLag
    {
        #region Public Methods

        /// <summary>
        /// Add lag columns/rows to the <see cref="DataSet.DataList"/>.
        /// </summary>
        /// <param name="dataSet">The <see cref="DataSet"/> that needs Dummies and/or Lag added.</param>
        /// <param name="doAddLag">An array with the same length like the <see cref="DataSet.DataList"/>. Each index in the array corresponds to a <see cref="Data"/> record.</param>
        /// <param name="numberOfLags">The number of lags that need to be added.</param>
        public bool AddLag(DataSet dataSet, List<bool> doAddLag, int numberOfLags)
        {
            return AddDummyLag(dataSet, doAddLag, DataType.Lag, numberOfLags);
        }

        /// <summary>
        /// Add dummy values to the <see cref="DataSet.DataList"/>.
        /// </summary>
        /// <param name="dataSet">The <see cref="DataSet"/> that needs Dummies and/or Lag added.</param>
        /// <param name="doAddDummies">An array with the same length like the <see cref="DataSet.DataList"/>. Each index in the array corresponds to a <see cref="Models.Data"/> record.</param>
        public bool AddDummies(DataSet dataSet, List<bool> doAddDummies)
        {
            return AddDummyLag(dataSet, doAddDummies, DataType.Dummy);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Add lag or dummies to the <see cref="DataSet"/>.
        /// </summary>
        /// <param name="dataSet">The <see cref="DataSet"/> that needs Dummies and/or Lag added.</param>
        /// <param name="doAdd">A <see cref="IReadOnlyList{T}"/> of <see cref="bool"/>s that indicates which <see cref="Models.Data"/> in the <see cref="DataSet"/> needs lag or dummies.</param>
        /// <param name="type">Indicates if lag or dummies have to be added.</param>
        /// <param name="iterations">(Optional) How many lags should be added. Should be left blank for dummies. Default is 0.</param>
        private bool AddDummyLag(DataSet dataSet, IReadOnlyList<bool> doAdd, DataType type, int iterations = 0)
        {
            // Check the input so everything is working like intended.
            switch (type)
            {
                case DataType.Lag:
                    if (!new CheckInput(dataSet, "Lag", doAdd, DefaultCheck.Numeric).Successful) return false;
                    break;
                case DataType.Dummy:
                    if (!new CheckInput(dataSet, "Dummy", doAdd, DefaultCheck.Nonnumeric, dataType: DataType.Dummy).Successful) return false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            // Initialize easy to use row and column.
            var row = dataSet.Range.Row + dataSet.Range.Rows.Count - 1;
            var column = dataSet.Range.Column + dataSet.Range.Columns.Count - 1;

            for (var i = 0; i < doAdd.Count; i++)
            {
                if (!doAdd[i]) continue;

                var uniqueValues = new List<dynamic>();
                if (type == DataType.Dummy)
                {
                    // Get the unique values.
                    foreach (var d in dataSet.DataList[i].GetValuesList())
                        if (!uniqueValues.Contains(d))
                            uniqueValues.Add(d);
                    iterations = uniqueValues.Count;
                }

                for (var j = 1; j <= iterations; j++)
                {
                    // Increment the column counter by one.
                    column++;
                    row++;

                    // Determine the name of the column.
                    string name;
                    switch (type)
                    {
                        case DataType.Dummy:
                            name = dataSet.DataList[i].Name.Replace("NORUST_", "") + " = " + uniqueValues[j - 1];
                            break;

                        case DataType.Lag:
                            name = dataSet.DataList[i].Name.Replace("NORUST_", "") + " (Lag" + j + ")";
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(type), type, null);
                    }

                    // Write the column's name to the sheet.
                    if (dataSet.Layout == Layout.Columns)
                        dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row - 1, column] = name;
                    else
                        dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column - 1] = name;

                    // Write the data to the sheet.
                    var offset = 0;
                    foreach (var d in dataSet.DataList[i].GetValuesList())
                    {
                        var exitLoop = false;

                        switch (type)
                        {
                            case DataType.Dummy:
                                if (dataSet.Layout == Layout.Columns)
                                    dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row + offset++, column] = d?.ToString() == uniqueValues[j - 1]?.ToString() ? 1 : 0;
                                else
                                    dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column + offset++] = d?.ToString() == uniqueValues[j - 1]?.ToString() ? 1 : 0;
                                break;
                            case DataType.Lag:
                                if (dataSet.Layout == Layout.Columns)
                                {
                                    if (dataSet.DataList[i].Range.Row + j + offset < dataSet.Range.Row + dataSet.Range.Rows.Count)
                                        dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row + j + offset++, column] = d;
                                    else
                                        exitLoop = true;
                                }
                                else
                                {
                                    if (dataSet.DataList[i].Range.Column + j + offset < dataSet.Range.Column + dataSet.Range.Columns.Count)
                                        dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column + j + offset++] = d;
                                    else
                                        exitLoop = true;
                                }
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(type), type, null);
                        }

                        if (exitLoop) break;
                    }

                    // Range of the data.
                    dynamic upperLeftCell, lowerRightCell;
                    if (dataSet.Layout == Layout.Columns)
                    {
                        upperLeftCell = dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row, column];
                        lowerRightCell = dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row + dataSet.DataList[i].Range.Rows.Count - 1, column];
                    }
                    else
                    {
                        upperLeftCell = dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column];
                        lowerRightCell = dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column + dataSet.DataList[i].Range.Columns.Count - 1];
                    }
                    var range = dataSet.Sheet.Range[upperLeftCell, lowerRightCell];

                    // Add the data to the lists.
                    var data = new Models.Data(dataSet.Sheet, range, name);
                    dataSet.DataList.Add(data);
                    if (type == DataType.Dummy)
                        dataSet.DummyList.Add(data);
                    else
                        dataSet.LagList.Add(data);
                }
            }

            // Update the range.
            dynamic dataSetUpperLeftCell = dataSet.Sheet.Cells[dataSet.Range.Row, dataSet.Range.Column];
            dynamic dataSetLowerRightCell = dataSet.Layout == Layout.Columns ? dataSet.Sheet.Cells[dataSet.Range.Row + dataSet.Range.Rows.Count - 1, column] : dataSet.Sheet.Cells[row, dataSet.Range.Column + dataSet.Range.Columns.Count - 1];
            dataSet.Range = dataSet.Sheet.Range[dataSetUpperLeftCell, dataSetLowerRightCell];

            return true;
        }

        #endregion
    }
}