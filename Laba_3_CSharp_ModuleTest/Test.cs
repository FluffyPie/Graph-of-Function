using Laba_3_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Laba_3_CSharp_ModuleTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CycloidTestXValue()
        {        
            Laba_3_CSharp.Code.Calculations Calc = new Laba_3_CSharp.Code.Calculations();
            double Coefficient = 2;
            double Radius = 25;
            double ExpectedValue = 35.404;
            Assert.AreEqual(ExpectedValue, Math.Round(Calc.AxisYCalculation(Coefficient, Radius),3));


        }
        [TestMethod]
        public void CycloidTestYValue()
        {

            Laba_3_CSharp.Code.Calculations Calc = new Laba_3_CSharp.Code.Calculations();
            double Coefficient = 3;
            double Radius = 12;
            double ExpectedValue = 23.88;
            Assert.AreEqual(ExpectedValue, Math.Round(Calc.AxisYCalculation(Coefficient, Radius), 3));

        }
    }
}


