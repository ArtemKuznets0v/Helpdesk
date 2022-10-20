using Helpdesk.Data;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Helpdesk.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Administrator")]
    public class CompanyController : Controller
    {

        private readonly ApplicationDbContext _db;
       

        private readonly ICompanyService service;


        public CompanyController(ICompanyService service, ApplicationDbContext db)
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
        public IActionResult Create(Companys obj)
        {

            if (ModelState.IsValid)
            {
                service.Create(obj);
                return RedirectToAction("Index");
            }
                return View(obj);
        }
        //[Authorize(Roles = "Administrator")]
        public  IActionResult Index(string? searchString, int pg = 1)
        {
            
            const int pageSize = 2;
            if (pg < 1)
                pg = 1;

            return View(new Pageres<Companys>
            {
                Items = service.SearchPaged(searchString,pageSize,pg),
                SearchString = searchString

            }) ;
            
        }
    }
}
