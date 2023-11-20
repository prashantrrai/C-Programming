using Microsoft.AspNetCore.Mvc;

namespace sqlconnection.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookCreate()
        {
            return View();
        }
    }
}
