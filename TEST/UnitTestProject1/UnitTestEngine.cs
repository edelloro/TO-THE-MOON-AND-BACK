
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoonAndBackCalculatorApplication.ConstantEngine;
using MoonAndBackCalculatorApplication.Model;


namespace UnitTestProjectEngineCalculator
{
    [TestClass]
    public class UnitTest_CalculatePI
    {


        [TestMethod]
        public void TestMethod_Nilakantha()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.NilakanthaEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate(10000);
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID NILAKANTHA CALCULATION");
        }


        [TestMethod]
        public void TestMethod_MonteCarlo_1000()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.MonteCarlo2DEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate(1000);
            Assert.AreEqual(rc.PI, 3.14, 0.10, "INVALID MONTECARLO CALCULATION");
        }


        [TestMethod]
        public void TestMethod_MonteCarlo_10000()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.MonteCarlo2DEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate(10000);
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID MONTECARLO CALCULATION");
        }


        [TestMethod]
        public void TestMethod_MonteCarlo3D_100()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.MonteCarlo3DEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate(100);
            Assert.AreEqual(rc.PI, 3.141, 0.005, "INVALID MONTECARLO 3D CALCULATION");
        }


        [TestMethod]
        public void TestMethod_DotNet()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.DotNetEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate();
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID DOTNET CALCULATION");
        }


        [TestMethod]
        public void TestMethod_EgyptianPyramid()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.EgyptianPyramidEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate();
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID EGYPT CALCULATION");
        }


        [TestMethod]
        public void TestMethod_ArcTangent()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.ArcTangentEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate();
            Assert.AreEqual(rc.PI, 3.14, 0.05, "INVALID ARCTANGENT CALCULATION");
        }


        [TestMethod]
        public void TestMethod_GregoryLeibniz_HundredMillionCalc()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.GregoryLeibnizEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate(1000000*10);
            Assert.AreEqual(rc.PI, 3.14, 0.005, "INVALID GREGORY-LEIBNIZ CALCULATION");
        }



        [TestMethod]
        public void TestMethod_Pyramid2DEngine()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine(PI_ENGINE_TYPE.Triangle2DEngine);
            //engine = model.GetconstantEngine(PI_ENGINE_TYPE.GregoryLeibnizEngine);
            CalculatorResult rc = null;
            rc = engine.Calculate(1000);
            Assert.AreEqual(rc.PI, 3.14, 0.10, "INVALID PYRAMID2D CALCULATION");
        }

    }
}
