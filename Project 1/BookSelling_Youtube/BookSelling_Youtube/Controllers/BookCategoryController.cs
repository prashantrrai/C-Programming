using Microsoft.AspNetCore.Mvc;

namespace BookSelling_Youtube.Controllers
{
    public class BookCategoryController : Controller
    {
        public IActionResult BookCreate()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
    }
}
