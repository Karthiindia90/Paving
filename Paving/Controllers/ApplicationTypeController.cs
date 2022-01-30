using Microsoft.AspNetCore.Mvc;
using Paving.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paving.Models;

namespace Paving.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ApplicationType> applicationTypeList = _db.ApplicationType;

            return View(applicationTypeList);
        }
        public IActionResult Create()
        {
            return View();
        }

        //post the data 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            _db.ApplicationType.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
