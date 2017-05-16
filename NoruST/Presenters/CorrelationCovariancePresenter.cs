using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using NoruST.Domain;
using NoruST.Forms;

namespace NoruST.Presenters
{
    public class CorrelationCovariancePresenter
    {
        private CorrelationCovarianceForm view;
        private DataSetManagerPresenter presenter;

        public CorrelationCovariancePresenter(DataSetManagerPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void openView()
        {
            view = view.createAndOrShowForm();
            view.setPresenter(this);
        }

        public BindingList<DataSet> dataSets()
        {
            return presenter.getModel().getDataSets();
        }

        public void createCorrelationCovariance(List<Variable> variables, bool correlation, bool covariance)
        {
            _Worksheet sheet = correlation && covariance ? WorksheetHelper.NewWorksheet("Correlation and Covariance") : correlation ? WorksheetHelper.NewWorksheet("Correlation") : WorksheetHelper.NewWorksheet("Covariance");
            int correlationRow = 2;
            int covarianceRow = correlation ? 4 + variables.Count : 2;

            if (correlation)
            {
                sheet.Cells[correlationRow - 1, 1] = "Linear Correlation Table";
                for (int i = 0; i < variables.Count; i++)
                {
                    Variable varCol = variables[i];
                    var varColRange = varCol.getRange().Address(true, true, true);
                    sheet.Cells[correlationRow + i, 1] = varCol.name;
                    sheet.Cells[correlationRow - 1, 2 + i] = varCol.name;
                    for (int j = i; j < variables.Count; j++)
                    {
                        Variable varRow = variables[j];
                        var varRowRange = varRow.getRange().Address(true, true, true);
                        if (i == j)
                        {
                            sheet.Cells[correlationRow + i, 2 + i] = 1.0;
                        }
                        else
                        {
                            sheet.WriteFunction(correlationRow + j, 2 + i, "CORREL(" + varColRange + "," + varRowRange + ")");
                            sheet.WriteFunction(correlationRow + i, 2 + j, AddressConverter.CellAddress(correlationRow + j, 2 + i, false, false));
                        }
                    }
                }
            }
            if (covariance)
            {
                sheet.Cells[covarianceRow - 1, 1] = "Covariance Table";
                for (int i = 0; i < variables.Count; i++)
                {
                    Variable varCol = variables[i];
                    var varColRange = varCol.getRange().Address(true, true, true);
                    sheet.Cells[covarianceRow + i, 1] = varCol.name;
                    sheet.Cells[covarianceRow - 1, 2 + i] = varCol.name;
                    for (int j = i; j < variables.Count; j++)
                    {
                        Variable varRow = variables[j];
                        var varRowRange = varRow.getRange().Address(true, true, true);
                        if (i == j)
                        {
                            sheet.WriteFunction(covarianceRow + i, 2 + i, "VAR(" + varColRange + ")");
                        }
                        else
                        {
                            sheet.WriteFunction(covarianceRow + j, 2 + i, "COVAR(" + varRowRange + "," + varColRange + ")");
                            sheet.WriteFunction(covarianceRow + i, 2 + j, AddressConverter.CellAddress(covarianceRow + j, 2 + i, false, false));
                        }
                    }
                }
            }

            
            sheet.Range["B1", "ZZ200"].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            if (correlation)
            {
                sheet.Range[AddressConverter.CellAddress(correlationRow - 1, 1, false, false), AddressConverter.CellAddress(correlationRow - 1, variables.Count + 1, false, false)].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlDouble;
                sheet.Range[AddressConverter.CellAddress(correlationRow, 2, false, false), AddressConverter.CellAddress(correlationRow + variables.Count - 1, variables.Count + 1, false, false)].NumberFormat = "0.000";
            }
            if (covariance)
            {
                sheet.Range[AddressConverter.CellAddress(covarianceRow - 1, 1, false, false), AddressConverter.CellAddress(covarianceRow - 1, variables.Count + 1, false, false)].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlDouble;
                sheet.Range[AddressConverter.CellAddress(covarianceRow, 2, false, false), AddressConverter.CellAddress(covarianceRow + variables.Count - 1, variables.Count + 1, false, false)].NumberFormat = "0.000";
            }
            for (int i = 1; i <= variables.Count + 1; i++)
            {
                ((Range)sheet.Cells[1, i]).EntireColumn.AutoFit();
            }
            Globals.ExcelAddIn.Application.ActiveWindow.DisplayGridlines = false;
        }
    }
}
