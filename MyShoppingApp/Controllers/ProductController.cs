using Microsoft.AspNetCore.Mvc;
using MyShoppingApp.Models;

namespace MyShoppingApp.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> productList = new List<Product>();
        public IActionResult Index()
        {
            //List<int> products = new List<int>();
            //products.Add(1);
            //List<Product> productlist = new List<Product>();
            //Product productobj = new Product();
            ////productobj.Id = 1;
            //productobj.Name = "Test1";
            //productobj.Description = "Test1";
            //productobj.Category = "Sports";
            //productlist.Add(productobj);

            return View(productList);
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
            if (productList.Count==0)
            {
                product.Id = 1;
            }
            else
            {
                product.Id = productList[productList.Count - 1].Id + 1;
            }
            productList.Add(product);
            return View("index",productList);
        }
        public IActionResult EditProduct(int id)
        {
            var result = productList.Where(obj=>obj.Id == id).ToList();
            return View(result[0]);
        }
    }
}
