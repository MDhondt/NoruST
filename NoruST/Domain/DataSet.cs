using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Office.Interop.Excel;
using static NoruST.Domain.RangeLayout;

namespace NoruST.Domain
{
    public class DataSet : INotifyPropertyChanged
    {

        private _Worksheet worksheet;
        private RangeLayout rangeLayout;
        private bool variableNamesInFirstRowOrColumn;
        private BindingList<Variable> variables = new BindingList<Variable>();
        private string inputtedRange = null;
        private Range range;
        public string Range
        {
            get { return inputtedRange ?? range.Address(true, true); }
            set
            {
                try
                {
                    Range rangeFromString = worksheet.Range[value, Type.Missing];
                    inputtedRange = null;
                    SetField(ref range, rangeFromString, "Range");
                }
                catch (Exception e)
                {
                    inputtedRange = value;
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { SetField(ref name, value, "Name"); }
        }

        public DataSet()
        {

        }

        public DataSet(_Worksheet worksheet, Range range, string name, RangeLayout rangeLayout, bool variableNamesInFirstRowOrColumn, List<Variable> variables)
        {
            this.worksheet = worksheet;
            this.range = range;
            this.name = name;
            this.rangeLayout = rangeLayout;
            this.variableNamesInFirstRowOrColumn = variableNamesInFirstRowOrColumn;
            this.variables = new BindingList<Variable>(variables);
        }

        public _Worksheet getWorksheet()
        {
            return worksheet;
        }

        public Range getRange()
        {
            return range;
        }

        public string getName()
        {
            return name;
        }

        public bool getVariableNamesInFirstRowOrColumn()
        {
            return variableNamesInFirstRowOrColumn;
        }

        public RangeLayout getRangeLayout()
        {
            return rangeLayout;
        }

        public BindingList<Variable> getVariables()
        {
            return variables;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            if (propertyName == "Range") recalculateVariables();
            OnPropertyChanged(propertyName);
            return true;
        }

        private void recalculateVariables()
        {
            List<Variable> newVariables = DataSetFactory.createVariables(worksheet, range, rangeLayout, variableNamesInFirstRowOrColumn);
            bool rangesHaveChanged = false;
            foreach (Variable currentVariable in variables)
            {
                bool currentVariableExistsInNewVariables = false;
                foreach (Variable newVariable in newVariables)
                    if (currentVariable.Range.Equals(newVariable.Range))
                        currentVariableExistsInNewVariables = true;
                if (!currentVariableExistsInNewVariables)
                    rangesHaveChanged = true;
            }
            if (rangesHaveChanged || variables.Count == 0)
            {
                variables.Clear();
                foreach (Variable newVariable in newVariables)
                    variables.Add(newVariable);
            }
        }
    }
}