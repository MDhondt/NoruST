using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoruST.Models
{
    public class RegressionModel
    {
        public bool fittedVSActual { get; set; }
        public bool residualsVSX { get; set; }
        public bool residualsVSFitted { get; set; }
        public bool regressionEquation { get; set; }
        public double confidenceLevel { get; set; }
    }
}
