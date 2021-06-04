using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFirstMVC.Models;

namespace WebAppFirstMVC.Controllers
{
    public class ProductsController : Controller
    {
        Entities db = new Entities();

        // GET: Products
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("login", "home");
            }
            else
            {          
                List<Products> model = db.Products.ToList();
                db.Dispose();

                return View(model);
            }
        }

        public ActionResult TuoteKuvat()
        {
            Entities db = new Entities();
            List<Products> model = db.Products.ToList();
            db.Dispose();

            return View(model);
        }

        public ActionResult Dashboard()
        {
            Entities db = new Entities();
            List<Products> model = db.Products.ToList();
            db.Dispose();

            return View(model);
        }
    }
}