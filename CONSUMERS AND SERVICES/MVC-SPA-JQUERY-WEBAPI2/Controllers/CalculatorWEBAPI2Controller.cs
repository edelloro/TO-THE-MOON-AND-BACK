using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoonAndBackCalculatorApplication.Models;
using MoonAndBackCalculatorApplication.Engine;


namespace MoonAndBackCalculatorApplication.Controllers
{
    public class CalculatorWEBAPI2Controller : ApiController
    {
        // WEBAPI2 HAS METHOD SIGNATURE ROUTING
        public  CalculatorResultModel Get()
        {
            constantModel model = new constantModel() ;
            IconstantEngine engine = null;
            engine = model.GetconstantEngine( );
            CalculatorResultModel rc = null;
            rc = engine.Calculate();
            return new CalculatorResultModel(rc.PI ,  rc.CalculationTime);
        }
    }
}