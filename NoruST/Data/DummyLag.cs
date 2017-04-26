using System;
using System.Collections.Generic;
using NoruST.Models;

namespace NoruST.Data
{
    public class DummyLag
    {
        private bool AddDummyLag(DataSet dataSet, IReadOnlyList<bool> doAdd, DataType type, int iterations = 0)
        {
            var row = dataSet.Range.Row + dataSet.Range.Rows.Count - 1;
            var column = dataSet.Range.Column + dataSet.Range.Columns.Count - 1;

            for (var i = 0; i < doAdd.Count; i++)
            {
                if (!doAdd[i]) continue;

                var uniqueValues = new List<dynamic>();
                foreach (var d in dataSet.DataList[i].GetValuesList())
                    if (!uniqueValues.Contains(d))
                        uniqueValues.Add(d);
                iterations = uniqueValues.Count;

                for (var j = 1; j <= iterations; j++)
                {
                    // Increment the column counter by one.
                    column++;
                    row++;

                    // Determine the name of the column.
                    string name = dataSet.DataList[i].Name.Replace("NORUST_", "") + " = " + uniqueValues[j - 1];

                    // Write the column's name to the sheet.
                    if (dataSet.Layout == Layout.Columns)
                        dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row - 1, column] = name;
                    else
                        dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column - 1] = name;

                    // Write the data to the sheet.
                    var offset = 0;
                    foreach (var d in dataSet.DataList[i].GetValuesList())
                    {
                        if (dataSet.Layout == Layout.Columns)
                            dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row + offset++, column] =
                                d?.ToString() == uniqueValues[j - 1]?.ToString() ? 1 : 0;
                        else
                            dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column + offset++] =
                                d?.ToString() == uniqueValues[j - 1]?.ToString() ? 1 : 0;
                    }

                    // Range of the data.
                    dynamic upperLeftCell, lowerRightCell;
                    if (dataSet.Layout == Layout.Columns)
                    {
                        upperLeftCell = dataSet.Sheet.Cells[dataSet.DataList[i].Range.Row, column];
                        lowerRightCell =
                            dataSet.Sheet.Cells[
                                dataSet.DataList[i].Range.Row + dataSet.DataList[i].Range.Rows.Count - 1, column];
                    }
                    else
                    {
                        upperLeftCell = dataSet.Sheet.Cells[row, dataSet.DataList[i].Range.Column];
                        lowerRightCell = dataSet.Sheet.Cells[row,
                            dataSet.DataList[i].Range.Column + dataSet.DataList[i].Range.Columns.Count - 1];
                    }
                    var range = dataSet.Sheet.Range[upperLeftCell, lowerRightCell];

                    // Add the data to the lists.
                    var data = new Models.Data(dataSet.Sheet, range, name);
                    dataSet.DataList.Add(data);
                    dataSet.DummyList.Add(data);
                }
            }

            // Update the range.
            dynamic dataSetUpperLeftCell = dataSet.Sheet.Cells[dataSet.Range.Row, dataSet.Range.Column];
            dynamic dataSetLowerRightCell = dataSet.Layout == Layout.Columns
                ? dataSet.Sheet.Cells[dataSet.Range.Row + dataSet.Range.Rows.Count - 1, column]
                : dataSet.Sheet.Cells[row, dataSet.Range.Column + dataSet.Range.Columns.Count - 1];
            dataSet.Range = dataSet.Sheet.Range[dataSetUpperLeftCell, dataSetLowerRightCell];

            return true;
        }
    }
}