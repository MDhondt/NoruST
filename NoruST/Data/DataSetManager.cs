using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using NoruST.Forms;
using NoruST.Models;

// ReSharper disable LoopCanBePartlyConvertedToQuery
// ReSharper disable LocalizableElement

namespace NoruST.Data
{
    /// <summary>
    /// <para>DataSet Manager.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 18, 2016</para>
    /// </summary>
    public class DataSetManager
    {
        #region Fields

        private DataSetManagerForm _dataSetManagerForm;

        #endregion

        #region Public Methods

        /// <summary>
        /// Create a new data set.
        /// </summary>
        public void NewDataSet()
        {
            // Initialize the Worksheet and Range.
            var sheet = (_Worksheet)Globals.ThisAddIn.Application.ActiveSheet;
            var range = (Range)sheet.Cells.Application.Selection;

            // Check if the selected Range is not in a DataSet.
            var hasIntersection = false;
            var dataSetName = "";
            foreach (var dataSet in Globals.ThisAddIn.DataSets)
                if (sheet == dataSet.Sheet && Globals.ThisAddIn.Application.Intersect(range, dataSet.Range) != null)
                {
                    hasIntersection = true;
                    dataSetName = dataSet.Name;
                    break;
                }

            // If intersections were found, prompt the user if the Form is already open.
            if (_dataSetManagerForm != null && _dataSetManagerForm.Visible && hasIntersection)
            {
                // Warn the user there is an intersection.
                var intersectionResult = MessageBox.Show("The selected range intersects with Data Set '" + dataSetName + $"'.{Environment.NewLine}{Environment.NewLine}Do you wish to continue anyway?", "NoruST - Data Set Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Abort if the 'No' button or no buttons were pressed.
                if (intersectionResult == DialogResult.None || intersectionResult == DialogResult.No)
                    return;

                // If the user pressed the 'Yes' button, continue.
                hasIntersection = false;
            }

            // If there is no intersection or reset by the warning, add the DataSet.
            if (!hasIntersection)
            {
                // Check the selected Range so only 1 Cell is selected.
                if (range.Rows.Count == 1 && range.Columns.Count == 1)
                {
                    // Expand the Range and select the DataSet.
                    range = range.ExpandSelection(sheet);
                    range.Select();
                }

                // Request to add the new DataSet.
                var result = MessageBox.Show("Do you want to add the range " + range.Address(true, true) + " as a new data set?", "NoruST - Data Set Manager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                // If the user pressed the 'Yes' button, add the data set.
                if (result == DialogResult.Yes)
                    Globals.ThisAddIn.DataSets.Add(new DataSet(sheet, range));

                // Abort when the 'Cancel' button or no buttons were pressed, do nothing.
                if (result != DialogResult.Yes && result != DialogResult.No) return;
            }

            // Show the DataSet Manager window. 
            _dataSetManagerForm = _dataSetManagerForm.ShowForm();
            _dataSetManagerForm.DataSetManager = this;
        }

        #endregion
    }
}