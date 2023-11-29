using Crud_Web_App.Data;
using Crud_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud_Web_App.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _datacontext;

        public RegistrationController(ApplicationDbContext database)
        {
            _datacontext = database;
        }
        public IActionResult Index()
        {
            IEnumerable<Registration> data = _datacontext.Registrations;
            return View(data);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registration obj)
        {
            if (ModelState.IsValid)
            {
                _datacontext.Registrations.Add(obj);
                _datacontext.SaveChanges();
                //TempData["success"] = "Country Added Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET-Update
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var registartiondata = _datacontext.Registrations.Find(id);

            if (registartiondata == null)
            {
                return NotFound();
            }

            return View(registartiondata);
        }


        //POST-UPdate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Registration obj)
        {
            try
            {
                var newdata = await _datacontext.Registrations.FindAsync(id);

                newdata.Name = obj.Name;
                newdata.Email = obj.Email;
                newdata.Password = obj.Password;
                newdata.Phone = obj.Phone;

                if (ModelState.IsValid)
                {
                    _datacontext.Update(newdata);
                    await _datacontext.SaveChangesAsync();
                    //TempData["success"] = "Country Updated Successfully";

                    return RedirectToAction("Index");
                }
                return View(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Get delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await _datacontext.Registrations.FirstOrDefaultAsync(obj => obj.Id == id);

            if (data == null)
            {
                return NotFound();
            }

            return View(data);
        }


        //delete post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePOST(int? id)
        {
            var data = await _datacontext.Registrations.FindAsync(id);

            if (data == null)
            {
                return NotFound();
            }

            _datacontext.Registrations.Remove(data);
            await _datacontext.SaveChangesAsync();
            //TempData["success"] = "Country Deleted Successfully";

            return RedirectToAction("Index");
        }


		//GET Details
		public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                var persondata = await _datacontext.Registrations.FirstOrDefaultAsync(p => p.Id == id);

                if (persondata == null)
                {
                    return NotFound();
                }

                return View(persondata);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

    }
}
