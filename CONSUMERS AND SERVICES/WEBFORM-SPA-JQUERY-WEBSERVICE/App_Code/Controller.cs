using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Web.Services;
using MoonAndBackCalculatorApplication.ConstantEngine;
using MoonAndBackCalculatorApplication.Model;

namespace MoonAndBackCalculatorApplication.Controllers
{

    /// <summary>
    /// Summary description for Controller
    /// </summary>
    [WebService(Namespace = "http://JenniferNine.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.Web.Script.Services.ScriptService]
    public class Controller : System.Web.Services.WebService
    {

        public Controller()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public CalculatorResult Calculate()
        {
            ConstantModel model = new ConstantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine();
            CalculatorResult rc = null;
            rc = engine.Calculate();
            return new CalculatorResult(rc.PI, rc.CalculationTime);
        }
    }
}