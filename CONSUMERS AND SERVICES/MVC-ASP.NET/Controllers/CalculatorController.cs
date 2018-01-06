using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoonAndBackCalculatorApplication.ConstantEngine;

using MoonAndBackCalculatorApplication.Model;



namespace MoonAndBackCalculatorApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index(string btnCalculate)
        
        {
           
            if (btnCalculate == "Calculate") { 
                ConstantModel model = new ConstantModel() ;
                IconstantEngine engine = null;
                engine = model.GetconstantEngine();
                CalculatorResult rc = null;
                rc = engine.Calculate();
                return View(new CalculatorResult(rc.PI, rc.CalculationTime));
            }
            else
            {
                return View(new CalculatorResult());
            }

        }
    }
}