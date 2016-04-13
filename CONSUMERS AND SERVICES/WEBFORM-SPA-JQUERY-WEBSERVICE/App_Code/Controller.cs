using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Web.Services;
using MoonAndBackCalculatorApplication.Engine;


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
        public CalculatorResultModel Calculate()
        {
           

            constantModel model = new constantModel();

            IconstantEngine engine = null;

            engine = model.GetconstantEngine();

            CalculatorResultModel rc = null;

            rc = engine.Calculate();

            return new CalculatorResultModel(rc.PI,
                                             rc.CalculationTime);
        }

    }


}