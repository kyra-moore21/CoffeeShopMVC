using Microsoft.AspNetCore.Mvc;
using CoffeeShopProductsMVC;
using CoffeeShopProductsMVC.Models;
using System.Diagnostics.Eventing.Reader;

namespace CoffeeShopProductsMVC.Controllers
{
    public class ProductController : Controller
    {
        CoffeeShopContext dbContext = new CoffeeShopContext();
       
        public IActionResult Index()
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }

        public IActionResult Details(int id) 
        { 
            Product result = dbContext.Products.FirstOrDefault(p => p.Id == id);
            return View(result);
        }

        public IActionResult ListByCategory(string category)
        {
            List<Product> result = dbContext.Products.Where(p => p.Category == category).ToList();
            return View(result);
        }
    }
}
