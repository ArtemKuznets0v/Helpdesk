using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Helpdesk.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Administrator")]
    public class ProgramController : Controller
    {
   
        private readonly ApplicationDbContext _db;


        private readonly IProgramControllerService service;


        public ProgramController(IProgramControllerService service, ApplicationDbContext db)
        {
            this.service = service;
            _db = db;
        }
        public IActionResult Index() => View(service.GetAllPrograms());

        public IActionResult Create()
        {

            return View();
        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Programs obj)
        {

            if (ModelState.IsValid)
            {
                service.Create1(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
