using Microsoft.AspNetCore.Mvc;
using MyShopingApp.Models;
namespace MyShopingApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Category()
        {
            List<Category> categoryList = new List<Category>();
            Category catObj = new Category();
            catObj.Category_Id = 101;
            catObj.Category_Name = "Ekart";
            catObj.Category_Description = "Shoping";
            categoryList.Add(catObj);

            catObj = new Category();
            catObj.Category_Id = 102;
            catObj.Category_Name = "Myntra";
            catObj.Category_Description = "Shoping";
            categoryList.Add(catObj);

            return View(categoryList);
        }
        public IActionResult index()
        {
            return View();
        }
    }
}