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
            // FIELD VALIDATIONS
            // OR USE GENERIC HTTP ERROR VALUE FUNCTION
            // NLOG TRANSACTIONS AND ERRORS
            // VALIDATION SHOULD OCCUR AT EACH LEVEL OF COMMUNICATION
            // HTML VALIDATION BEFORE SEND
            // WEBAPI2 VALIDATION

         
            constantModel model = new constantModel();
            IconstantEngine engine = null;
            engine = model.GetconstantEngine();
            CalculatorResultModel rc = null;
            rc = engine.Calculate();
            return new CalculatorResultModel(rc.PI, rc.CalculationTime);

        }

    }


}