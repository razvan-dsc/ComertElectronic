using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProiectWAD.Interfaces.Repository;
using ProiectWAD.Models;

namespace ProiectWAD.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoryController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = _categoriesRepository.GetAll();
            return View(categoryList);
        }

        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category category)
        {
            _categoriesRepository.Add(category);
            return RedirectToAction("Index");
        }
    }
}
