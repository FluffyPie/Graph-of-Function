using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3_CSharp.Code
{
    class Calculations
    {
        public double AxisXCalculation(double Coefficient, double Radius)
        {
            return Radius * (Coefficient - Math.Sin(Coefficient));
        }
        public double AxisYCalculation(double Coefficient, double Radius)
        {
            return Radius * (1 - Math.Cos(Coefficient));
        }
    }
}
