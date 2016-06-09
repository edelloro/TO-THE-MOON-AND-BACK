using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoonAndBackCalculatorApplication.ConstantEngine;
using MoonAndBackCalculatorApplication.Model;



namespace MoonAndBackCalculatorApplication.Controllers
{
    public class CalculatorWEBAPI2Controller : ApiController
    {

        // WEBAPI2 HAS METHOD SIGNATURE ROUTING
        public  CalculatorResult Get()
        {
            constantModel model = new constantModel() ;
            IconstantEngine engine = null;
            engine = model.GetconstantEngine();
            CalculatorResult rc = null;
            rc = engine.Calculate();
            return new CalculatorResult(rc.PI ,  rc.CalculationTime);
        }

      
    }
}