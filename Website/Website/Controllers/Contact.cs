using System.Web.Mvc;

namespace Website.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult show()
        {
            return View("contact");
        }
    }
}