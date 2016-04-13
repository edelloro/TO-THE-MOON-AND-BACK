using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoonAndBackCalculatorApplication.Controllers
{
    public class CalculatorAngularController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
    }
}