using System;
using Microsoft.Office.Interop.Excel;

namespace NoruST
{
    /// <summary>
    /// <para>RangeHelper.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 18, 2016</para>
    /// </summary>
    public static class RangeHelper
    {
        /// <summary>
        /// Get the last row number of a <see cref="Range"/>.
        /// </summary>
        /// <param name="range">The <see cref="Range"/>.</param>
        /// <returns>The number of the last row.</returns>
        public static int GetLastRow(this Range range)
        {
            return range.Row + range.Rows.Count - 1;
        }

        /// <summary>
        /// Get the last column number of a <see cref="Range"/>.
        /// </summary>
        /// <param name="range">The <see cref="Range"/>.</param>
        /// <returns>The number of the last column.</returns>
        public static int GetLastColumn(this Range range)
        {
            return range.Column + range.Columns.Count - 1;
        }

        /// <summary>
        /// Check a given range for missing data and expand it if missing data is found.
        /// </summary>
        /// <param name="sheet">The active <see cref="_Worksheet"/>.</param>
        /// <param name="range">The initial selected range.</param>
        /// <param name="foundFirstRow">(Optional) Indication if the first row of the data set is found.</param>
        /// <param name="foundFirstColumn">(Optional) Indication if the first column of the data set is found.</param>
        /// <param name="foundLastRow">(Optional) Indication if the last row of the data set is found.</param>
        /// <param name="foundLastColumn">(Optional) Indication if the last column of the data set is found.</param>
        /// <returns>A new range of cells with no missing data.</returns>
        public static Range ExpandSelection(this Range range, _Worksheet sheet, bool foundFirstRow = false, bool foundFirstColumn = false, bool foundLastRow = false, bool foundLastColumn = false)
        {
            // Check for invalid arguments.
            if (sheet == null) throw new ArgumentNullException(nameof(sheet));
            if (range == null) throw new ArgumentNullException(nameof(range));

            // Declare some variables for later.
            var firstRow = range.Row;
            var firstColumn = range.Column;
            var lastRow = range.Row + range.Rows.Count - 1;
            var lastColumn = range.Column + range.Columns.Count - 1;

            // Check if the cell a row higher has a value.
            if (!foundFirstRow && range.Row != 1 && ((Range)sheet.Cells[firstRow - 1, firstColumn]).Value2 != null)
            {
                firstRow -= 1;
                if (firstRow == 1)
                    foundFirstRow = true;
            }
            else
                foundFirstRow = true;

            // Check if the cell a column before has a value.
            if (!foundFirstColumn && range.Column != 1 && ((Range)sheet.Cells[firstRow, firstColumn - 1]).Value2 != null)
            {
                firstColumn -= 1;
                if (firstColumn == 1)
                    foundFirstColumn = true;
            }
            else foundFirstColumn = true;

            // Check if the cell a row lower has a value.
            if (!foundLastRow && ((Range)sheet.Cells[lastRow + 1, lastColumn]).Value2 != null)
                lastRow += 1;
            else
                foundLastRow = true;

            // Check if the cell a column after has a value.
            if (!foundLastColumn && ((Range)sheet.Cells[lastRow, lastColumn + 1]).Value2 != null)
                lastColumn += 1;
            else
                foundLastColumn = true;

            // Set the new range to check.
            range = sheet.Range[sheet.Cells[firstRow, firstColumn], sheet.Cells[lastRow, lastColumn]];

            // Check the new range for more missing data.
            if (!foundFirstRow || !foundFirstColumn || !foundLastRow || !foundLastColumn)
                range = range.ExpandSelection(sheet, foundFirstRow, foundFirstColumn, foundLastRow, foundLastColumn);

            // Return the new found range
            return range;
        }

    }
}