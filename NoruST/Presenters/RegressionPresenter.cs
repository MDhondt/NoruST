using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using Microsoft.Office.Interop.Excel;
using NoruST.Domain;
using NoruST.Forms;
using NoruST.Models;
using DataSet = NoruST.Domain.DataSet;

namespace NoruST.Presenters
{
    public class RegressionPresenter
    {
        private RegressionForm view;
        private RegressionModel model;
        private DataSetManagerPresenter dataSetPresenter;
        private readonly WorksheetFunction _functions = Globals.ExcelAddIn.Application.WorksheetFunction;

        public RegressionPresenter(DataSetManagerPresenter presenter)
        {
            this.dataSetPresenter = presenter;
            model = new RegressionModel();
        }

        public RegressionModel getModel()
        {
            return model;
        }

        public void openView()
        {
            view = view.createAndOrShowForm();
            view.setPresenter(this);
        }

        public BindingList<DataSet> dataSets()
        {
            return dataSetPresenter.getModel().getDataSets();
        }

        public void createRegression(DataSet dataSet, List<Variable> independentVariables, Variable dependentVariable)
        {
            _Worksheet sheet = WorksheetHelper.NewWorksheet("Simple Regression");

            var matrixX = Matrix<double>.Build.Dense(dataSet.rangeSize(), independentVariables.Count + 1);
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                matrixX[i, 0] = 1;
                for (var j = 0; j < independentVariables.Count; j++)
                {
                    matrixX[i, j + 1] = dataSet.getValuesArray(independentVariables[j])[i];
                }
            }

            var matrixY = Matrix<double>.Build.Dense(dataSet.rangeSize(), 1);
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                matrixY[i, 0] = dataSet.getValuesArray(dependentVariable)[i];
            }

            var matrixXt = matrixX.Transpose();
            var matrixXtX = matrixXt * matrixX;
            var matrixInv = matrixXtX.Inverse();
            var matrixInvXt = matrixInv * matrixXt;
            var matrixResult = matrixInvXt * matrixY;

            const int title = 1;
            const int name = 3;
            const int betaCoeff = 2;
            const int stdErrorName = betaCoeff + 1;
            const int pValuesName = stdErrorName + 1;
            const int lowerLimitName = pValuesName + 1;
            const int upperLimitName = lowerLimitName + 1;
            var summaryName = name + independentVariables.Count + 3;
            var anovaTableName = summaryName + 3;
            const int degreesOfFreedomName = 2;
            const int sumOfSquaresName = 3;
            const int meanOfSquaresName = 4;
            const int anovaFValueName = 5;
            const int anovaPValueName = 6;
            var dataName = anovaTableName + 4;

            sheet.Cells[title, 1] = "Regression";
            sheet.Cells[name + 1, 1] = "Constant";
            sheet.Cells[name, betaCoeff] = "Beta";
            sheet.Cells[name, stdErrorName] = "Standard Error";
            sheet.Cells[name, pValuesName] = "P-Value";
            sheet.Cells[name, lowerLimitName] = "Lower Limit";
            sheet.Cells[name, upperLimitName] = "Upper Limit";
            sheet.Cells[summaryName + 1, 1] = "Regression Summary";
            sheet.Cells[summaryName, 2] = "R-Square";
            sheet.Cells[summaryName, 3] = "Adjusted R-Square";
            sheet.Cells[summaryName, 4] = "Standard Error of estimation";

            if (model.regressionEquation)
            {
                sheet.Cells[summaryName, 5] = "Regression Equation";
                var regressionEquation = "" + matrixResult[0, 0];
                for (var i = 0; i < independentVariables.Count; i++)
                {
                    regressionEquation = regressionEquation + " + (" + matrixResult[i + 1, 0] + "*" + independentVariables[i].name + ")";
                }
                sheet.Cells[summaryName + 1, 5] = dependentVariable.name + " = " + regressionEquation;
            }

            sheet.Cells[anovaTableName, 1] = "Anova Table";
            sheet.Cells[anovaTableName + 1, 1] = "Explained";
            sheet.Cells[anovaTableName + 2, 1] = "Unexplained";
            sheet.Cells[anovaTableName, degreesOfFreedomName] = "Degrees of Freedom";
            sheet.Cells[anovaTableName + 1, degreesOfFreedomName] = independentVariables.Count;
            var dF = dataSet.rangeSize() - 1 - independentVariables.Count;
            sheet.Cells[anovaTableName + 2, degreesOfFreedomName] = dF;
            sheet.Cells[anovaTableName, sumOfSquaresName] = "Sum of Squares";
            var sumOfSquare = CalculateSumOfSquares(dataSet, independentVariables, dependentVariable, matrixResult);
            sheet.Cells[anovaTableName + 1, sumOfSquaresName] = sumOfSquare[0];
            sheet.Cells[anovaTableName + 2, sumOfSquaresName] = sumOfSquare[1];
            sheet.Cells[anovaTableName, meanOfSquaresName] = "Mean of Squares";
            sheet.Cells[anovaTableName + 1, meanOfSquaresName] = sumOfSquare[0] / independentVariables.Count;
            sheet.Cells[anovaTableName + 2, meanOfSquaresName] = sumOfSquare[1] / (dataSet.rangeSize() - 1 - independentVariables.Count);
            sheet.Cells[anovaTableName, anovaFValueName] = "F";
            sheet.Cells[anovaTableName, anovaPValueName] = "P-Value";
            var fTest = (sumOfSquare[0] / independentVariables.Count) / (sumOfSquare[1] / (dataSet.rangeSize() - 1 - independentVariables.Count));
            sheet.Cells[anovaTableName + 1, anovaFValueName] = fTest;
            sheet.Cells[anovaTableName + 1, anovaPValueName] = _functions.FDist(fTest, independentVariables.Count, dataSet.rangeSize() - 1 - independentVariables.Count);
            sheet.Cells[dataName, 1] = "Data";
            sheet.Cells[dataName, 2] = "Y: " + dependentVariable.name;
            sheet.Cells[dataName, 3] = "Fit";
            sheet.Cells[dataName, 4] = "Residuals";

            // calculate r-square, adj r-square and std error of estimation
            var rSquare = CalculateRsquare(dataSet, independentVariables, dependentVariable, matrixResult);
            var adjRSquare = CalculateAdjRSquare(rSquare, matrixX);
            var stdErrorEstimation = CalculateStdErrorEstimation(dataSet, independentVariables, dependentVariable, matrixResult);
            sheet.Cells[summaryName + 1, 2] = rSquare;
            sheet.Cells[summaryName + 1, 3] = adjRSquare;
            sheet.Cells[summaryName + 1, 4] = stdErrorEstimation;

            for (int i = 1; i < matrixResult.RowCount; i++)
            {
                sheet.Cells[name + i + 1, 1] = independentVariables[i - 1].name;
            }
            var meanOfSquaresError = sumOfSquare[1] / (dataSet.rangeSize() - 1 - independentVariables.Count);
            for (var i = 0; i < matrixResult.RowCount; i++)
            {
                var coeff = matrixResult[i, 0];
                var stdError = Math.Sqrt(matrixInv[i, i] * meanOfSquaresError);
                var pValue = _functions.TDist(Math.Abs(coeff / stdError), dF, 2);
                var confidenceConstant = _functions.T_Inv_2T(1 - model.confidenceLevel, dF);
                var lower = coeff - stdError * confidenceConstant;
                var upper = coeff + stdError * confidenceConstant;
                sheet.Cells[name + i + 1, betaCoeff] = coeff;
                sheet.Cells[name + i + 1, stdErrorName] = stdError;
                sheet.Cells[name + i + 1, pValuesName] = pValue;
                sheet.Cells[name + i + 1, lowerLimitName] = lower;
                sheet.Cells[name + i + 1, upperLimitName] = upper;
            }

            for (var i = 0; i < independentVariables.Count; i++)
            {
                sheet.Cells[dataName, 5 + i] = independentVariables[i].name;
            }

            var nextFigure = CreateDataRegression(matrixX, matrixY, matrixResult, dataName, sheet);
            if (model.fittedVSActual)
            {
                var rangeX = sheet.Range[sheet.Cells[dataName + 1, 2], sheet.Cells[dataName + dataSet.rangeSize(), 2]];
                var rangeY = sheet.Range[sheet.Cells[dataName + 1, 3], sheet.Cells[dataName + dataSet.rangeSize(), 3]];
                nextFigure = CreateNewFigure(rangeX, rangeY, nextFigure, "Fitted Values vs Actual Y-Values: " + dependentVariable.name, sheet);
            }

            if (model.residualsVSFitted)
            {
                var rangeX = sheet.Range[sheet.Cells[dataName + 1, 3], sheet.Cells[dataName + dataSet.rangeSize(), 3]];
                var rangeY = sheet.Range[sheet.Cells[dataName + 1, 4], sheet.Cells[dataName + dataSet.rangeSize(), 4]];
                nextFigure = CreateNewFigure(rangeX, rangeY, nextFigure, "Residuals vs Fitted Values", sheet);
            }

            if (model.residualsVSX)
            {
                var rangeY = sheet.Range[sheet.Cells[dataName + 1, 4], sheet.Cells[dataName + dataSet.rangeSize(), 4]];
                for (var i = 0; i < independentVariables.Count; i++)
                {
                    var rangeX = sheet.Range[sheet.Cells[dataName + 1, 5 + i], sheet.Cells[dataName + dataSet.rangeSize(), 5 + i]];
                    var nameX = independentVariables[i].name;
                    nextFigure = CreateNewFigure(rangeX, rangeY, nextFigure, "Residuals vs " + nameX, sheet);
                }
            }
        }

        private int CreateDataRegression(Matrix<double> matrixX, Matrix<double> matrixY, Matrix<double> beta, int row, _Worksheet sheet)
        {
            var newRow = row + matrixY.RowCount + 2;

            for (var i = 0; i < matrixY.RowCount; i++)
            {
                var place = row + i + 1;
                sheet.Cells[place, 1] = i + 1;
                sheet.Cells[place, 2] = matrixY[i, 0];
                var fit = beta[0, 0];
                for (var j = 1; j < matrixX.ColumnCount; j++)
                {
                    sheet.Cells[place, 4 + j] = matrixX[i, j];
                    fit = fit + matrixX[i, j] * beta[j, 0];
                }
                sheet.Cells[place, 3] = fit;
                sheet.Cells[place, 4] = matrixY[i, 0] - fit;
            }
            return newRow;
        }

        private static int CreateNewFigure(Range rangeX, Range rangeY, int row, string name, _Worksheet sheet)
        {
            var charts = (ChartObjects)sheet.ChartObjects();
            var chartObject = charts.Add(10, row * 15, 400, 250);
            var chart = chartObject.Chart;

            chart.ChartType = XlChartType.xlXYScatter;
            chart.ChartWizard(Title: name, HasLegend: false);
            
            ((SeriesCollection)chart.SeriesCollection()).Add(rangeY);
            ((Series)chart.SeriesCollection(1)).Values = rangeY;
            ((Series)chart.SeriesCollection(1)).XValues = rangeX;
            ((Series)chart.SeriesCollection(1)).MarkerStyle = XlMarkerStyle.xlMarkerStyleCircle;

            return row + 20;
        }

        private double CalculateRsquare(DataSet dataSet, List<Variable> valueArrayX, Variable valueY, Matrix<double> beta)
        {
            double ssTot = 0;
            double ssRes = 0;
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                ssTot = ssTot + (dataSet.getValuesArray(valueY)[i] - _functions.Average(valueY.getRange())) * (dataSet.getValuesArray(valueY)[i] - _functions.Average(valueY.getRange()));
                var fittedValue = beta[0, 0];
                for (var j = 0; j < valueArrayX.Count; j++)
                {
                    fittedValue = fittedValue + beta[j + 1, 0] * dataSet.getValuesArray(valueArrayX[j])[i];
                }
                ssRes = ssRes + (dataSet.getValuesArray(valueY)[i] - fittedValue) * (dataSet.getValuesArray(valueY)[i] - fittedValue);
            }
            var rSquare = 1 - ssRes / ssTot;
            return rSquare;
        }

        private double CalculateAdjRSquare(double rSquare, Matrix<double> matrixX)
        {
            double n = matrixX.RowCount;
            double p = matrixX.ColumnCount - 1;
            var adjRSquare = 1 - (1 - rSquare) * (n - 1) / (n - p - 1);
            return adjRSquare;
        }

        private double CalculateStdErrorEstimation(DataSet dataSet, List<Variable> valueArrayX, Variable valueY, Matrix<double> beta)
        {
            double n = dataSet.rangeSize();
            double ssRes = 0;
            for (var i = 0; i < n; i++)
            {
                var fittedValue = beta[0, 0];
                for (var j = 0; j < valueArrayX.Count; j++)
                {
                    fittedValue = fittedValue + beta[j + 1, 0] * dataSet.getValuesArray(valueArrayX[j])[i];
                }
                ssRes = ssRes + (dataSet.getValuesArray(valueY)[i] - fittedValue) * (dataSet.getValuesArray(valueY)[i] - fittedValue);
            }
            var stdErrorEstimation = Math.Sqrt(ssRes / (n - 1 - valueArrayX.Count));
            return stdErrorEstimation;
        }

        private double[] CalculateSumOfSquares(DataSet dataSet, List<Variable> valueArrayX, Variable valueY, Matrix<double> beta)
        {
            var sumOfSquare = new double[2];
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                var fittedValue = beta[0, 0];
                for (var j = 0; j < valueArrayX.Count; j++)
                {
                    fittedValue = fittedValue + beta[j + 1, 0] * dataSet.getValuesArray(valueArrayX[j])[i];
                }
                sumOfSquare[0] = sumOfSquare[0] + (fittedValue - _functions.Average(valueY.getRange())) * (fittedValue - _functions.Average(valueY.getRange()));
                sumOfSquare[1] = sumOfSquare[1] + (dataSet.getValuesArray(valueY)[i] - fittedValue) * (dataSet.getValuesArray(valueY)[i] - fittedValue);
            }
            return sumOfSquare;
        }
    }
}