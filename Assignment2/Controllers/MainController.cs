using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            List<Product> prd = ProductDB.GetAllProducts();   
            return View(prd);
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(FormCollection itemData)
        {
            Product p = new Product();
            p.itemName = Request.Form["itemName"];
            p.description = Request.Form["description"];
            p.quantity = Convert.ToInt32(Request.Form["quantity"]);
            ProductDB.AddProduct(p);

            return View();
          
        }
        [HttpGet]
        public ActionResult ModelBinding()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ModelBinding(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductDB.AddProduct(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
    
}