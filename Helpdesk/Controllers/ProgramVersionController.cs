using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Helpdesk.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Administrator")]
    public class ProgramVersionController : Controller
    {
        private readonly ApplicationDbContext _db;


        private readonly IProgramVersionControllerService service;

        public IActionResult Index() => View(service.GetAllVers());

        public ProgramVersionController(IProgramVersionControllerService service, ApplicationDbContext db)
        {
            this.service = service;
            _db = db;
        }
        public IActionResult Create()
        {

            return View();
        }
        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vers obj)
        {

            if (ModelState.IsValid)
            {
                service.Create3(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
