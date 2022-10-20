using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Helpdesk.Controllers
{

    [Authorize]
    [Authorize(Roles = "Administrator")]
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _db;


        private readonly IRequestService service;

        public RequestController(IRequestService service, ApplicationDbContext db)
        {
            this.service = service;
            _db = db;
        }
        public IActionResult Index() => View(service.GetAllReq());
        public IActionResult Create()
        {

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Request obj)
        {

            if (ModelState.IsValid)
            {
                service.Create4(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
