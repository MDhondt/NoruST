using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoruST.Forms;
using NoruST.Models;
using NoruST.Presenters;
using NoruST.Domain;
using DataSet = NoruST.Domain.DataSet;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MathNet.Numerics.LinearAlgebra;

namespace NoruST.Presenters
{
    public class LogisticRegressionPresenter
    {
        private LogisticRegressionForm view;
        private LogisticRegressionModel model;
        private DataSetManagerPresenter dataSetPresenter;

        public LogisticRegressionPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new LogisticRegressionModel();
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

        public bool checkInput(DataSet dataSet, List<Variable> variables_x , List<Variable> variables_y)
        {
            if (dataSet == null || variables_x.Count() == 0 || variables_y.Count() == 0 || variables_y.Count() > 1)
            {
                MessageBox.Show(" Please correct all fields to perform logistic regression. Make sure that only one independent variable is selected.");
                return false;
            }
            // declare function to use function of excel
            var functions = Globals.ExcelAddIn.Application.WorksheetFunction;
            var sheet = WorksheetHelper.NewWorksheet("Logistic Regression");

            var matrixX = Matrix<double>.Build.Dense(dataSet.rangeSize(), variables_x.Count());
            var matrixY = Matrix<double>.Build.Dense(dataSet.rangeSize(), variables_y.Count());


            foreach (Variable variableX in variables_x)
            {
                int matrixindex_x = 0;
                double[,] array = RangeHelper.To2DDoubleArray(variableX.getRange());
                double[] array2 = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    array2[i] = array[i, 0];
                }
                for (var i = 0; i<dataSet.rangeSize(); i++)
                {
                    matrixX[i, matrixindex_x] = array2[i];
                }
                matrixindex_x++;
            }

            foreach (Variable variableY in variables_y)
            {
                int matrixindex_y = 0;
                double[,] array = RangeHelper.To2DDoubleArray(variableY.getRange());
                double[] array3 = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    array3[i] = array[i, 0];
                }
                for (var i = 0; i < dataSet.rangeSize(); i++)
                {
                    matrixY[i, matrixindex_y] = array3[i];
                }
                matrixindex_y++;
            }


                // calculate theta iteratively using newton's method, starting from zero matrix
                var startTheta = Matrix<double>.Build.Dense(variables_x.Count, 1);
                var theta = NewtonsMethod(matrixX, matrixY, startTheta);

                // calculate classification matrix
                var classificationMatrix = CalculateClassificationMatrix(matrixX, matrixY, theta);

                // calculate summary classification
                var summaryClassificationPercentages = SummaryClassification(classificationMatrix);

                var expThetaX = theta.Transpose() * matrixX.Transpose();


                var matrixV = Matrix<double>.Build.Dense(dataSet.rangeSize(), dataSet.rangeSize());
                for (var i = 0; i < dataSet.rangeSize(); i++)
                {
                    var prob = 1 / (1 + Math.Exp(-expThetaX[0, i]));
                    matrixV[i, i] = prob * (1 - prob);
                }

                var matrixCovar = (matrixX.Transpose() * matrixV * matrixX).Inverse();

                // locations of tables
                const int title = 1;
                const int summaryName = 3;
                const int name = summaryName + 6;
                const int betaCoeffName = 2;
                const int stdErrorName = betaCoeffName + 1;
                const int waldValueName = stdErrorName + 1;
                const int pValueName = waldValueName + 1;
                const int lowerLimitName = pValueName + 1;
                const int upperLimitName = lowerLimitName + 1;
                var classificationMatrixName = name + 3 + variables_x.Count;
                var summaryClassificationName = classificationMatrixName + 4;
                var dataName = summaryClassificationName + 5;
                var probName = variables_x.Count + 2;

                // names of variables on sheet
                sheet.Cells[title, 1] = "Logistic Regression";

                sheet.Cells[summaryName, 1] = "Summary";
                sheet.Cells[summaryName + 1, 1] = "Null Deviance";
                sheet.Cells[summaryName + 2, 1] = "Model Deviance";
                sheet.Cells[summaryName + 3, 1] = "Improvement";
                sheet.Cells[summaryName + 4, 1] = "P Value";

                sheet.Cells[name + 1, 1] = "Constant";
                sheet.Cells[name, betaCoeffName] = "Beta Coefficient";
                sheet.Cells[name, stdErrorName] = "Standard Error";
                sheet.Cells[name, waldValueName] = "Wald Value";
                sheet.Cells[name, pValueName] = "p Value";
                sheet.Cells[name, lowerLimitName] = "Lower Limit (95%)";
                sheet.Cells[name, upperLimitName] = "Upper Limit (95%)";

                for (var i = 0; i < variables_x.Count; i++)
                {
                    sheet.Cells[name + i + 2, 1] = variables_x[i].name;
                }

                sheet.Cells[classificationMatrixName, 1] = "Classification Matrix";
                sheet.Cells[classificationMatrixName, 2] = "1";
                sheet.Cells[classificationMatrixName, 3] = "0";
                sheet.Cells[classificationMatrixName, 4] = "Percentage Correct";
                sheet.Cells[classificationMatrixName + 1, 1] = "1";
                sheet.Cells[classificationMatrixName + 2, 1] = "0";

                sheet.Cells[summaryClassificationName, 1] = "Classification Summary";
                sheet.Cells[summaryClassificationName, 2] = "Percentage";
                sheet.Cells[summaryClassificationName + 1, 1] = "Correct";
                sheet.Cells[summaryClassificationName + 2, 1] = "Base";
                sheet.Cells[summaryClassificationName + 3, 1] = "Improvement";
                sheet.Cells[summaryClassificationName + 1, 2] = summaryClassificationPercentages[0];
                sheet.Cells[summaryClassificationName + 2, 2] = summaryClassificationPercentages[1];
                sheet.Cells[summaryClassificationName + 3, 2] = summaryClassificationPercentages[2];

            ((Range)sheet.Cells[summaryClassificationName, 1]).EntireColumn.AutoFit();
            ((Range)sheet.Cells[9, 1]).EntireRow.AutoFit();

            sheet.Cells[dataName, 1] = "";
                for (var i = 0; i < variables_x.Count; i++)
                {
                    sheet.Cells[dataName, 2 + i] = variables_x[i].name;
                }
                sheet.Cells[dataName, probName] = "Probability";
                sheet.Cells[dataName, probName + 1] = "Forecast";
                sheet.Cells[dataName, probName + 2] = "Class";

                for (var i = 0; i < dataSet.rangeSize(); i++)
                { //hier zit ergens het probleem
                    sheet.Cells[dataName + 1 + i, 1] = i + 1;
                    for (var j = 0; j < variables_x.Count; j++)
                    {
                        sheet.Cells[dataName + 1 + i, 2 + j] = matrixX[j, i];
                    }
                    var prob = 1 / (1 + Math.Exp(-expThetaX[0, i]));
                    sheet.Cells[dataName + 1 + i, probName] = prob;
                    if (prob > 0.5)
                        sheet.Cells[dataName + 1 + i, probName + 1] = 1;
                    else
                        sheet.Cells[dataName + 1 + i, probName + 1] = 0;
                    sheet.Cells[dataName + 1 + i, probName + 2] = matrixY[0,i];
                
            }
            double dF = dataSet.rangeSize() - variables_x.Count() - 1;
            
            // print out beta coefficients and std error of coefficient
            for (var i = 0; i < theta.RowCount; i++)
                {
                    sheet.Cells[name + i + 1, betaCoeffName] = theta[i, 0];
                    var stdError = Math.Sqrt(matrixCovar[i, i]);
                    sheet.Cells[name + i + 1, stdErrorName] = stdError;
                    sheet.Cells[name + i + 1, waldValueName] = theta[i, 0] / stdError;
                    var pValue = functions.TDist(Math.Abs(theta[i, 0] / stdError), dF, 2);
                    sheet.Cells[name + i + 1, pValueName] = pValue;
                    var confidenceConstant = 1.96;
                    var lower = theta[i, 0] - stdError * confidenceConstant;
                    var upper = theta[i, 0] + stdError * confidenceConstant;
                    sheet.Cells[name + i + 1, lowerLimitName] = lower;
                    sheet.Cells[name + i + 1, upperLimitName] = upper;
                }

                //print out classification matrix
                sheet.Cells[classificationMatrixName + 1, 2] = classificationMatrix[0];
                sheet.Cells[classificationMatrixName + 1, 3] = classificationMatrix[1];
                var n0 = Convert.ToDouble(classificationMatrix[0]) + Convert.ToDouble(classificationMatrix[1]);
                sheet.Cells[classificationMatrixName + 1, 4] = Convert.ToDouble(classificationMatrix[0]) / (Convert.ToDouble(classificationMatrix[0]) + Convert.ToDouble(classificationMatrix[1]));
                sheet.Cells[classificationMatrixName + 2, 2] = classificationMatrix[2];
                sheet.Cells[classificationMatrixName + 2, 3] = classificationMatrix[3];
                var n1 = Convert.ToDouble(classificationMatrix[2]) + Convert.ToDouble(classificationMatrix[3]);
                sheet.Cells[classificationMatrixName + 2, 4] = Convert.ToDouble(classificationMatrix[3]) / (Convert.ToDouble(classificationMatrix[2]) + Convert.ToDouble(classificationMatrix[3]));

                // summary measures
                var nullDeviance = 2 * (-n0 * Math.Log(n0 / (n0 + n1)) - n1 * Math.Log(n1 / (n0 + n1)));
                double modelDeviance = 0;

                for (var i = 0; i < dataSet.rangeSize(); i++)
                {
                    var prob = 1 / (1 + Math.Exp(-expThetaX[0, i]));
                    double yValue = matrixY[0, i] ;
                    modelDeviance = modelDeviance + yValue * Math.Log(1 / prob) + (1 - yValue) * Math.Log(1 / (1 - prob));
                }

                modelDeviance = modelDeviance * 2;

                sheet.Cells[summaryName + 1, 2] = nullDeviance;
                sheet.Cells[summaryName + 2, 2] = modelDeviance;
                sheet.Cells[summaryName + 3, 2] = nullDeviance - modelDeviance;
                sheet.Cells[summaryName + 4, 2] = "P Value";

                return true;
            }

            private Matrix<double> NewtonsMethod(Matrix<double> matrixX, Matrix<double> matrixY, Matrix<double> theta)
            {
                var matrixXX = matrixX.Transpose();
                var matrixYY = matrixY.Transpose();
                var row = matrixXX.RowCount;
                var column = matrixXX.ColumnCount;

            var hTheta = Matrix<double>.Build.Dense(1, column);
            for (var j = 0; j < 50; j++)
            {
                var expThetaX = theta.Transpose() * matrixXX;
                var gradient = Matrix<double>.Build.Dense(row, 1);
                var hessian = Matrix<double>.Build.Dense(row, row);
                    for (var i = 0; i < column; i++)
                    {
                        hTheta[0, i] = 1 / (1 + Math.Exp(-expThetaX[0, i]));
                        var gradientTemp = (hTheta[0, i] - matrixYY[0, i]) / column;
                        var hessianTemp = hTheta[0, i] * (1 - hTheta[0, i]) / column;

                        for (var k = 0; k < row; k++)
                        {
                            gradient[k, 0] = gradient[k, 0] + gradientTemp * matrixXX[k, i];
                            for (var l = 0; l < row; l++)
                            {
                                hessian[k, l] = hessian[k, l] + hessianTemp * matrixXX[k, i] * matrixXX[l, i];
                            }
                        }
                    }
                    theta = theta - hessian.Inverse() * gradient;
                }
                return theta;
            }
            private int[] CalculateClassificationMatrix(Matrix<double> matrixX, Matrix<double> matrixY, Matrix<double> theta)
            {
                var classificationMatrix = new[] { 0, 0, 0, 0 };

                for (var i = 0; i < matrixY.RowCount; i++)
                {
                    double expected = 0;
                    for (var j = 0; j < matrixX.ColumnCount; j++)
                    {
                        expected = expected + matrixX[i, j] * theta[j, 0];
                    }
                    if (expected > 0)
                    {
                        if (matrixY[i, 0] == 1)
                        {
                            classificationMatrix[0]++;
                        }
                        else
                        {
                            classificationMatrix[1]++;
                        }
                    }
                    else
                    {
                        if (matrixY[i, 0] == 0)
                        {
                            classificationMatrix[3]++;
                        }
                        else
                        {
                            classificationMatrix[2]++;
                        }
                    }
                }
                return classificationMatrix;
            }
            private static double[] SummaryClassification(IReadOnlyList<int> classificationMatrix)
            {
                var summaryClassificationPercentages = new[] { 0.0, 0.0, 0.0 };

                // total classification
                var total = (Convert.ToDouble(classificationMatrix[0]) + Convert.ToDouble(classificationMatrix[1]) + Convert.ToDouble(classificationMatrix[2]) + Convert.ToDouble(classificationMatrix[3]));

                // correct classification
                summaryClassificationPercentages[0] = (Convert.ToDouble(classificationMatrix[0]) + Convert.ToDouble(classificationMatrix[3])) / total;

                // base classification
                if (Convert.ToDouble(classificationMatrix[0]) + Convert.ToDouble(classificationMatrix[1]) > total / 2)
                {
                    summaryClassificationPercentages[1] = (Convert.ToDouble(classificationMatrix[0]) + Convert.ToDouble(classificationMatrix[1])) / total;
                }
                else
                {
                    summaryClassificationPercentages[1] = (Convert.ToDouble(classificationMatrix[2]) + Convert.ToDouble(classificationMatrix[3])) / total;
                }

                // improvement classification
                summaryClassificationPercentages[2] = (summaryClassificationPercentages[0] - summaryClassificationPercentages[1]) / (1 - summaryClassificationPercentages[1]);

                return summaryClassificationPercentages;
            }
       
        // einde copy oude code

    }
    
}
