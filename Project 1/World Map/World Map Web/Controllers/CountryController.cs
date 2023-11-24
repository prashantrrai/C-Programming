using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using World_Map_Web.Data;
using World_Map_Web.Models;

namespace World_Map_Web.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext _datacontext;

        public CountryController(ApplicationDbContext db)
        {
			_datacontext = db;
        }

        public IActionResult Index()
        {
            var objcountry = (IEnumerable<Country>)_datacontext.Country;
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
				_datacontext.Country.Add(obj);
				_datacontext.SaveChanges();
                TempData["success"] = "Country Added Successfully";
                return RedirectToAction("Index");
            }   
            return View(obj);
        }


		//GET-Update
		public IActionResult Edit(int? id)
		{
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var countrydata = _datacontext.Country.Find(id);
			/*          var countrysingle = _db.Country.SingleOrDefault(obj=> obj.CountryId == id);
						var countryfirst = _db.Country.FirstOrDefault(obj=> obj.CountryId == id);*/

			if (countrydata == null)
            {
                return NotFound();
            }

			return View(countrydata);
		}


		//POST-UPdate
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task< IActionResult> Edit(int id , Country ctr)
        {
            try
            { 
				var CountryData = await _datacontext.Country.FindAsync(id);

				CountryData.CountryName = ctr.CountryName;
				CountryData.Abbreviation = ctr.Abbreviation;
				CountryData.Currency = ctr.Currency;
				CountryData.DialingCode = ctr.DialingCode;
				CountryData.CountryCapital = ctr.CountryCapital;
				CountryData.Flag = ctr.Flag;
				CountryData.CreatedBy = ctr.CreatedBy;
				CountryData.ModifiedBy = ctr.ModifiedBy;
                CountryData.IsActive = ctr.IsActive;

				if (ModelState.IsValid)
				{
					_datacontext.Update(CountryData);
					await _datacontext.SaveChangesAsync();
                    TempData["success"] = "Country Updated Successfully";

                    return RedirectToAction("Index");
				}
				return View(ctr);
			}
            catch (Exception)
            {

                throw;
            }
		}

        //Get country data for delete using id
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await _datacontext.Country.FirstOrDefaultAsync(obj => obj.CountryId == id);

            if(data == null)
            {
                return NotFound();
            }

            return View(data);
        }

        //delete country post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> DeletePOST(int? id)
        {
            var countrydata = await _datacontext.Country.FindAsync(id);

            if(countrydata == null)
            {
                return NotFound();
            }

            _datacontext.Country.Remove(countrydata);
            await _datacontext.SaveChangesAsync();
            TempData["success"] = "Country Deleted Successfully";

            return RedirectToAction("Index");
        }
	}
}
    