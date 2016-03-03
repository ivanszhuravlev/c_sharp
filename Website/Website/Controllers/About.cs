using System.Web.Mvc;

namespace Website.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult show()
        {
            return View("about");
        }
    }
}