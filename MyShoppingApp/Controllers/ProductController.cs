using Microsoft.AspNetCore.Mvc;
using MyShoppingApp.Models;

namespace MyShoppingApp.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> productList = new List<Product>();
        public IActionResult Index()
        {
            List<int> products = new List<int>();
            products.Add(1);
            List<Product> productlist = new List<Product>();
            Product productobj = new Product();
            productobj.Id = 1;
            productobj.Name = "Test1";
            productobj.Description = "Test1";
            productobj.Category = "Sports";
            productlist.Add(productobj);

            return View(productlist);
        }

        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            //How to pass data from action to view page
            ViewBag.message = "Successfully Added......!";
            productList.Add(product);
            return View("index",productList);
        }
        public IActionResult EditProduct(int id)
        {
            return View();
        }
    }
}
