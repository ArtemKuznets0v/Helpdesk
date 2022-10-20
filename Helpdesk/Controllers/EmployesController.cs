using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Helpdesk.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Administrator")]
    public class EmployesController : Controller
    {
        

        private readonly ApplicationDbContext _db;


        private readonly IEmployesService service;
       

        public EmployesController(IEmployesService service, ApplicationDbContext db)
        {
            this.service = service;
            this._db = db;
        }
        public IActionResult Create()
        {

            return View();
        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employes obj)
        {

            if (ModelState.IsValid)
            {
                _db.Empl.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //[Authorize(Roles = "Administrator")]
        public IActionResult Index(string? searchString, int pg = 1)
        {

            const int pageSize = 2;
            if (pg < 1)
                pg = 1;

            return View(new Pageres<Employes>
            {
                Items = service.SearchPaged(searchString, pageSize, pg),
                SearchString = searchString

            });
        }

    }
}
