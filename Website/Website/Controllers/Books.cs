using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult show()
        {
            var books = BooksFactory.CreateBooks();
            return View("books", books);
        }
    }
}