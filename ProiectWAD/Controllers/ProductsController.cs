using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProiectWAD.Interfaces.Repository;
using ProiectWAD.Models;

namespace ProiectWAD.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> productList = _productsRepository.GetAll();
            return View(productList);
        }

        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(Product product)
        {
            _productsRepository.Add(product);
            return RedirectToAction("Index");
        }
    }
}
