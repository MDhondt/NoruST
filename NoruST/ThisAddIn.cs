using System;
using System.Collections.Generic;
using NoruST.Models;

namespace NoruST
{
    public partial class ThisAddIn
    {
        #region Startup / Shutdown

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }

        #endregion

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }

        #endregion

        #region Global properties

        /// <summary>
        /// A list with the different <see cref="DataSet"/>s in the document.
        /// </summary>
        public List<DataSet> DataSets { get; set; } = new List<DataSet>();

        #endregion
    }
}