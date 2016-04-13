using System.Web;
using System.Web.Mvc;

namespace MoonAndBackCalculatorApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
    }
}