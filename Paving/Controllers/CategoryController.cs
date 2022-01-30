using Microsoft.AspNetCore.Mvc;
using Paving.Data;
using Paving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paving.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
      
        public IActionResult Index()
        {
            IEnumerable<Category> categorylist = _db.Category;

            return View(categorylist);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
