using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiKart.BusinessLayer;

namespace MultiKart.Controllers
{
    public class CategoryController : Controller
    {
       
        public ActionResult Index()
        {
            ProductManager productManager = new ProductManager();




            return View(productManager.List());


        }
    }
}