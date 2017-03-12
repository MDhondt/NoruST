using Microsoft.Office.Interop.Excel;

namespace NoruST
{
    /// <summary>
    /// <para>Address Converter.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Mar 16, 2016</para>
    /// </summary>
    public static class AddressConverter
    {
        /// <summary>
        /// Converts any <see cref="Range"/> to an address (e.g., "A1:C7", "$A1:C$7", "$A$1:$C$7").
        /// </summary>
        /// <param name="range">The range you want to get the address from.</param>
        /// <param name="absoluteRow">(Optional) Set to true if the row should be absolute.</param>
        /// <param name="absoluteColumn">(Optional) Set to true if the column should be absolute.</param>
        /// <param name="external">(Optional) Set to true to return an external reference.</param>
        /// <returns>The address of the range (e.g., "A1:C7", "$A1:C$7", "$A$1:$C$7").</returns>
        public static string Address(this Range range, bool absoluteRow = false, bool absoluteColumn = false, bool external = false)
        {
            return range.AddressLocal[absoluteRow, absoluteColumn, XlReferenceStyle.xlA1, external];
        }

        /// <summary>
        /// Converts any combination of row and column to an address (e.g., "A1:C7", "$A1:C$7", "$A$1:$C$7").
        /// </summary>
        /// <param name="row">The number of the row.</param>
        /// <param name="column">The number of the column.</param>
        /// <param name="absoluteRow">(Optional) Set to false if the row should not be absolute.</param>
        /// <param name="absoluteColumn">(optional) Set to false if the column should not be absolute.</param>
        /// <returns>The address of the cell (e.g., "A1:C7", "$A1:C$7", "$A$1:$C$7").</returns>
        public static string CellAddress(int row, int column, bool absoluteRow = true, bool absoluteColumn = true)
        {
            var sheet = (Worksheet)Globals.ThisAddIn.Application.ActiveSheet;

            return sheet.Cells[row, column].Address(absoluteRow, absoluteColumn);
        }
    }
}