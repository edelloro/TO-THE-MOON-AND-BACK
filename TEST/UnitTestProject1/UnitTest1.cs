using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoonAndBackCalculatorApplication.Engine;

namespace UnitTestProjectEngineCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_MonteCarlo_1000()
        {
            constantModel model = new constantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.MonteCarloEngine);
            CalculatorResultModel rc = null;
            rc = engine.Calculate(1000);
            Assert.AreEqual(rc.PI, 3.14, 0.10, "INVALID MONTECARLO CALCULATION");
        }


        [TestMethod]
        public void TestMethod_MonteCarlo_10000()
        {
            constantModel model = new constantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.MonteCarloEngine);
            CalculatorResultModel rc = null;
            rc = engine.Calculate(10000);
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID MONTECARLO CALCULATION");
        }


        [TestMethod]
        public void TestMethod_DotNet()
        {
            constantModel model = new constantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.DotNetEngine);
            CalculatorResultModel rc = null;
            rc = engine.Calculate();
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID DOTNET CALCULATION");
        }

        [TestMethod]
        public void TestMethod_EgyptianPyramid()
        {
            constantModel model = new constantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.EgyptianPyramidEngine);
            CalculatorResultModel rc = null;
            rc = engine.Calculate();
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID EGYPT CALCULATION");
        }


        [TestMethod]
        public void TestMethod_ArcTangent()
        {
            constantModel model = new constantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.ArcTangentEngine);
            CalculatorResultModel rc = null;
            rc = engine.Calculate();
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID ARCTANGENT CALCULATION");
        }


        [TestMethod]
        public void TestMethod_GregoryLeibniz_HundredMillionCalc()
        {
            constantModel model = new constantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.GregoryLeibnizEngine);
            CalculatorResultModel rc = null;
            rc = engine.Calculate(1000000*10);
            Assert.AreEqual(rc.PI, 3.14, 0.005, "INVALID GREGORY-LEIBNIZ CALCULATION");
        }    
    }
}
