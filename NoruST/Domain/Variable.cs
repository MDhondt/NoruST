using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace NoruST.Domain
{
    public class Variable
    {

        private _Worksheet worksheet;
        public string name { get; set; }
        private Range range;
        public string Range => range.Address(true, true);

        public Variable(string name, _Worksheet worksheet, Range range)
        {
            this.name = name;
            this.worksheet = worksheet;
            this.range = range;
        }

        public Range getRange()
        {
            return range;
        }

        public dynamic[] getValuesArray(RangeLayout rangeLayout)
        {
            var valuesList = new List<dynamic>();
            if (rangeLayout == RangeLayout.COLUMNS)
            {
                for (int row = 0; row < range.Rows.Count; row++)
                {
                    var value = ((Range)worksheet.Cells[range.Row + row, range.Column]).Value2;
                    valuesList.Add(value);
                }
            }
            else
            {
                for (int column = 0; column < range.Columns.Count; column++)
                {
                    var value = ((Range)worksheet.Cells[range.Row, range.Column + column]).Value2;
                    valuesList.Add(value);
                }
            }
            return valuesList.ToArray();
        }
    }
}