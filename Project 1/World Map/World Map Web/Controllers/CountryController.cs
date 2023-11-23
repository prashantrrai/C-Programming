using Microsoft.AspNetCore.Mvc;
using World_Map_Web.Data;
using World_Map_Web.Models;

namespace World_Map_Web.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CountryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objcountry = (IEnumerable<Country>)_db.Country;
            return View(objcountry);
        }


        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country obj)

        {
            if (obj.CountryName == obj.Abbreviation)
            {
                ModelState.AddModelError("countryname", "Country Name and Abbreviation cannot be Same");
            }

            if (ModelState.IsValid)
            {
                _db.Country.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }   
            return View();
        }
    }
}
    