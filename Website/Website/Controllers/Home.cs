using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult show()
        {
            return View("home");
        }
    }
}