using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InClassWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace InClassWebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);

            return View(product);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }
    }
}