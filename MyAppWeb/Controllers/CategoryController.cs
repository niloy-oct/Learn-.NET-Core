using Microsoft.AspNetCore.Mvc;
using MyAppWeb.Data;
using MyAppWeb.Models;
using System.Collections.Generic;

namespace MyAppWeb.Controllers
{
    public class CategoryController : Controller
    {
        private DatabaseContext _dbContext;

        public CategoryController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _dbContext.Categories;
            return View(categories);
        }
    }
}
