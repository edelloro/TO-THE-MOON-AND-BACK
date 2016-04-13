using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoonAndBackCalculatorApplication.Engine;



namespace MoonAndBackCalculatorApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index(string calculate)
        
        {
            string ERIC = calculate;

            if (calculate == "Calculate") { 
                constantModel model = new constantModel() ;
                IconstantEngine engine = null;
                engine = model.GetconstantEngine();
                CalculatorResultModel rc = null;
                rc = engine.Calculate();
                return View(new CalculatorResultModel(rc.PI, 
                                                      rc.CalculationTime));
            }
            else
            {
                return View(new CalculatorResultModel());
            }

        }
    }
}