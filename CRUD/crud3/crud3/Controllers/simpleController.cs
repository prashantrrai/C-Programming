using crud3.ApplicationDbContext;
using crud3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud3.Controllers
{
	public class simpleController : Controller
	{
		private readonly myDbContext _datacontext;
        public simpleController(myDbContext db)
        {
            _datacontext = db;
        }


        // GET: simpleController
        public ActionResult Index()
		{
			var employee = (IEnumerable<employee>) _datacontext.employees;
			return View(employee);
		}

		// GET: simpleController/Details/5
		public ActionResult Details(int? id)
		{
			if(id == null)
			{
				return NotFound();
			}

			var empData = _datacontext.employees.Find(id);

			if(empData == null)
			{
				return NotFound();
			}

			return View(empData);
		}

		// GET: simpleController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: simpleController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(employee obj)
		{
			try
			{
                if (ModelState.IsValid)
                {
                    _datacontext.employees.Add(obj);
                    _datacontext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(obj);
            }
			catch(Exception err)
			{
				throw err;
            }

		}

		// GET: simpleController/Edit/5
		public ActionResult Edit(int? id)
		{
			if(id == null)
			{
                return NotFound();
            }

			var data = _datacontext.employees.Find(id);
			if(data == null)
			{
				return NotFound(data);
			}
            return View(data);
		}

		// POST: simpleController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int? id, employee obj)
		{
			try
			{
                var data = _datacontext.employees.Find(id);

				data.username = obj.username;
				data.password = obj.password;

				if (ModelState.IsValid)
				{
					_datacontext.employees.Update(data);
					_datacontext.SaveChanges();
				}

                return RedirectToAction("Index");
			}
			catch
			{
				return View(obj);
			}
		}

		// GET: simpleController/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var data = _datacontext.employees.Find(id);

			if (data == null)
			{
				return NotFound();
			}
			return View(data);
		}

		// POST: simpleController/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeletePost(int? id)
		{
			try
			{
				var data = _datacontext.employees.Find(id);

                _datacontext.employees.Remove(data);
				_datacontext.SaveChanges();

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}
