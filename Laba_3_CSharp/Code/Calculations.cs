using System;


namespace Laba_3_CSharp.Code
{
    public class Calculations
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
