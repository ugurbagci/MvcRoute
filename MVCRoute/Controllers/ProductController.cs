using MVCRoute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoute.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();


        public ActionResult Index()
        {
            var productList = db.Products.ToList();
            return View(productList);
        }
        public ActionResult Details(string ProductName, int ProductId)
        {
            return View(db.Products.Where(x => x.ProductID == ProductId).FirstOrDefault());
        }
    }
}