using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using NoruST.Domain;

namespace NoruST.Models
{
    class XRChartModel
    {
        public BindingList<float> averages = new BindingList<float>();
        public BindingList<Variable> variables = new BindingList<Variable>();
        public Domain.DataSet dataSet { get; set; }
        private int size;

        public BindingList<float> subsampleAverages(Domain.DataSet dataSet)
        {
            size = dataSet.getVariables().Count();
            for (int i = 1; i < size; i++)
            {
                float Avg = i * 2; // hier moet het gemiddelde van elke variabele berekend worden en per for-loop toevoegd worden aan averages
                averages.Add(Avg);
                    }
            return averages;
        }
    }
}
