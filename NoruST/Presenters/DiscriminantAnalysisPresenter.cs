﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoruST.Forms;
using NoruST.Models;
using DataSet = NoruST.Domain.DataSet;
using NoruST.Presenters;
using NoruST.Domain;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MathNet.Numerics.LinearAlgebra;

namespace NoruST.Presenters
{
    public class DiscriminantAnalysisPresenter
    {
        private DiscriminantAnalysisForm view;
        private DiscriminantAnalysisModel model;
        private DataSetManagerPresenter dataSetPresenter;

        public DiscriminantAnalysisPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new DiscriminantAnalysisModel();
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

        public bool checkInput(DataSet dataSet, List<Variable> independentVariables, Variable dependentVariable, string probability, string misclassification0, string misclassification1)
        {

            if (dataSet == null || independentVariables.Count() == 0)
            {
                MessageBox.Show(" Please correct all fields to perform logistic regression. Make sure that only one independent variable is selected.");
                return false;
            }
            // declare function to use function of excel
            var functions = Globals.ExcelAddIn.Application.WorksheetFunction;
            var sheet = WorksheetHelper.NewWorksheet("Discriminant Analysis");

            var matrixX = Matrix<double>.Build.Dense(dataSet.rangeSize(), independentVariables.Count);
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                for (var j = 0; j < independentVariables.Count; j++)
                {
                    matrixX[i, j] = dataSet.getValuesArray(independentVariables[j])[i];
                }
            }

            var matrixY = Matrix<double>.Build.Dense(dataSet.rangeSize(), 1);
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                matrixY[i, 0] = dataSet.getValuesArray(dependentVariable)[i];
            }


            // Tables location
            const int setupName = 3;
            const int summaryName = setupName + 4;
            const int functionName = summaryName + 4;
            var matrixName = functionName + independentVariables.Count + 2;
            var classificationName = matrixName + 4;
            var covarsName = classificationName + 5;
            var cutOffName = covarsName + independentVariables.Count + 2;
            var dataName = cutOffName + 3;
            var discrimName = independentVariables.Count + 2;

            // write tables
            sheet.Cells[1, 1] = "Discriminant Analysis";

            sheet.Cells[setupName, 1] = "Setup";
            sheet.Cells[setupName, 2] = "Prior Probability of 0";
            sheet.Cells[setupName, 3] = "Misclassication cost: 0 as 1";
            sheet.Cells[setupName, 4] = "Misclassication cost: 1 as 0";
            ((Range)sheet.Cells[setupName, 1]).EntireColumn.AutoFit();
            ((Range)sheet.Cells[setupName, 2]).EntireColumn.AutoFit();
            ((Range)sheet.Cells[setupName, 3]).EntireColumn.AutoFit();
            ((Range)sheet.Cells[setupName, 4]).EntireColumn.AutoFit();

            sheet.Cells[setupName + 1, 2] = probability;
            sheet.Cells[setupName + 1, 3] = misclassification0;
            sheet.Cells[setupName + 1, 4] = misclassification1;

            sheet.Cells[summaryName, 1] = "Sample Summary";
            sheet.Cells[summaryName + 1, 1] = "0";
            sheet.Cells[summaryName + 2, 1] = "1";
            sheet.Cells[summaryName, 2] = "Sample Size";
            for (var i = 0; i < independentVariables.Count; i++)
            {
                sheet.Cells[summaryName, 3 + i] = "Mean " + independentVariables[i].name;
            }

            sheet.Cells[functionName, 1] = "Discriminant Function";
            sheet.Cells[functionName, 2] = "Coefficient";
            for (var i = 0; i < independentVariables.Count; i++)
            {
                sheet.Cells[functionName + 1 + i, 1] = independentVariables[i].name;
            }

            sheet.Cells[matrixName, 1] = "Classification Matrix";
            sheet.Cells[matrixName + 1, 1] = "0";
            sheet.Cells[matrixName + 2, 1] = "1";
            sheet.Cells[matrixName, 2] = "0";
            sheet.Cells[matrixName, 3] = "1";
            sheet.Cells[matrixName, 4] = "Correct";

            sheet.Cells[classificationName, 1] = "Classification Summary";
            sheet.Cells[classificationName + 1, 1] = "Correct";
            sheet.Cells[classificationName + 2, 1] = "Base";
            sheet.Cells[classificationName + 3, 1] = "Improvement";

            sheet.Cells[covarsName, 1] = "Covariance Matrix";
            for (var i = 0; i < independentVariables.Count; i++)
            {
                sheet.Cells[covarsName + 1 + i, 1] = independentVariables[i].name;
                sheet.Cells[covarsName, 2 + i] = independentVariables[i].name;
            }

            sheet.Cells[cutOffName, 1] = "Cut off ";


            sheet.Cells[dataName, 1] = "Data";
            for (var i = 0; i < independentVariables.Count; i++)
            {
                sheet.Cells[dataName, 2 + i] = independentVariables[i].name;
            }
            sheet.Cells[dataName, discrimName] = "Discriminant";
            sheet.Cells[dataName, discrimName + 1] = "Class";
            sheet.Cells[dataName, discrimName + 2] = "Analysis";


            var mean = new double[independentVariables.Count];
            var mean0 = Matrix<double>.Build.Dense(independentVariables.Count, 1);
            var mean1 = Matrix<double>.Build.Dense(independentVariables.Count, 1);

            // mean for all X
            for (var i = 0; i < independentVariables.Count; i++)
            {
                mean[i] = matrixX.Column(i).Average();
            }

            var n = dataSet.rangeSize();
            var n0 = 0;
            var n1 = 0;

            var total0 = new double[independentVariables.Count];
            var total1 = new double[independentVariables.Count];
            //mean for X_0 and X_1, total elements n_0 and n_1
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                if (matrixY[i,0] == 0)
                {
                    n0++;
                    for (var j = 0; j < independentVariables.Count; j++)
                    {
                        total0[j] = total0[j] + matrixX[i,j];
                    }
                }
                else
                {
                    n1++;
                    for (var j = 0; j < independentVariables.Count; j++)
                    {
                        total1[j] = total1[j] + matrixX[i,j];
                    }
                }
            }
            sheet.Cells[summaryName + 1, 2] = n0;
            sheet.Cells[summaryName + 2, 2] = n1;
            for (var i = 0; i < independentVariables.Count; i++)
            {
                mean0[i, 0] = total0[i] / Convert.ToDouble(n0);
                mean1[i, 0] = total1[i] / Convert.ToDouble(n1);
                sheet.Cells[summaryName + 1, 3 + i] = mean0[i, 0];
                sheet.Cells[summaryName + 2, 3 + i] = mean1[i, 0];
            }

            // create X_average matrix
            var matrixXAver = Matrix<double>.Build.Dense(dataSet.rangeSize(), independentVariables.Count);
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                if (matrixY[i,0] == 0)
                {
                    for (var j = 0; j < independentVariables.Count; j++)
                    {
                        matrixXAver[i, j] = mean0[j, 0];
                    }
                }
                else
                {
                    for (var j = 0; j < independentVariables.Count; j++)
                    {
                        matrixXAver[i, j] = mean1[j, 0];
                    }
                }
            }

            var matrixXTransposed = matrixX.Transpose() * matrixX;
            var matrixXAverTransposed = matrixXAver.Transpose() * matrixXAver;
            var matrixS = Matrix<double>.Build.Dense(matrixXTransposed.RowCount, matrixXTransposed.ColumnCount);
            for (var i = 0; i < matrixS.RowCount; i++)
            {
                for (var j = 0; j < matrixS.ColumnCount; j++)
                {
                    matrixS[i, j] = (matrixXTransposed[i, j] - matrixXAverTransposed[i, j]) / (n - independentVariables.Count);
                    sheet.Cells[covarsName + 1 + i, 2 + j] = matrixS[i, j];
                }
            }

            var matrixSInv = matrixS.Inverse();
            var matrixResult = matrixSInv * (mean0 - mean1);

            for (var i = 0; i < matrixResult.RowCount; i++)
            {
                sheet.Cells[functionName + 1 + i, 2] = matrixResult[i, 0];
            }

            var z0 = mean0.Transpose() * matrixResult;
            var z1 = mean1.Transpose() * matrixResult;

            var cutOff = (z0[0, 0] + z1[0, 0]) / 2 + Math.Log(Convert.ToDouble(misclassification1) * (1 - Convert.ToDouble(probability)) / Convert.ToDouble(misclassification0) / Convert.ToDouble(probability));

            sheet.Cells[cutOffName + 1, 1] = cutOff;

            var correctClass0 = 0;
            var correctClass1 = 0;
            for (var i = 0; i < dataSet.rangeSize(); i++)
            {
                sheet.Cells[dataName + 1 + i, 1] = i + 1;
                double discrim = 0;
                for (var j = 0; j < independentVariables.Count; j++)
                {
                    sheet.Cells[dataName + 1 + i, j + 2] = matrixX[i,j];
                    discrim = discrim + matrixX[i, j] * matrixResult[j, 0];
                }
                sheet.Cells[dataName + 1 + i, discrimName] = discrim;
                sheet.Cells[dataName + 1 + i, discrimName + 1] = matrixY[i,0];
                if (discrim > cutOff)
                {
                    sheet.Cells[dataName + 1 + i, discrimName + 2] = 0;
                    if (matrixY[i, 0] == 0)
                    {
                        correctClass0++;
                    }
                }
                else
                {
                    sheet.Cells[dataName + 1 + i, discrimName + 2] = 1;
                    if (matrixY[i, 0] == 1)
                    {
                        correctClass1++;
                    }
                }
            }
            sheet.Cells[matrixName + 1, 2] = correctClass0;
            sheet.Cells[matrixName + 1, 3] = n0 - correctClass0;
            sheet.Cells[matrixName + 2, 3] = correctClass1;
            sheet.Cells[matrixName + 2, 2] = n1 - correctClass1;
            sheet.Cells[matrixName + 1, 4] = Convert.ToDouble(correctClass0) / Convert.ToDouble(n0);
            sheet.Cells[matrixName + 2, 4] = Convert.ToDouble(correctClass1) / Convert.ToDouble(n1);

            var correct = Convert.ToDouble(correctClass0 + correctClass1) / Convert.ToDouble(n);
            double basis;
            if (Convert.ToDouble(n0) * 2 > Convert.ToDouble(n))
                basis = Convert.ToDouble(n0) / Convert.ToDouble(n);
            else
                basis = Convert.ToDouble(n1) / Convert.ToDouble(n);
            var improvement = (correct - basis) / (1 - basis);

            sheet.Cells[classificationName + 1, 2] = correct;
            sheet.Cells[classificationName + 2, 2] = basis;
            sheet.Cells[classificationName + 3, 2] = improvement;

            return true;

        }
    }
}
