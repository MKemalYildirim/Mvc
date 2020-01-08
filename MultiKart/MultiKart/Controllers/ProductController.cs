using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiKart.EntityLayer;
using MultiKart.BusinessLayer;
using MultiKart.Models;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.IO;



namespace MultiKart.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager productManager = new ProductManager();

        Product product = new Product();
                   
        // GET: Product
        public ActionResult Index()
        {



            return View(productManager.List());
        }

        [HttpPost]
                public ActionResult Creat(FormCollection form,IEnumerable<HttpPostedFileBase> files)
            {




                foreach (var item in files)
                {


              
                   string path = Path.Combine(Server.MapPath("~/Content/images"), Guid.NewGuid().ToString() + "_" + Path.GetFileName(item.FileName));
                    item.SaveAs(path);
                







                if (product.Image1 == null)
                {
                    product.Image1 = path;

                }
                else if (product.Image2 == null)
                {
                    product.Image2 = path;
                }
                else if (product.Image3 == null)
                {
                    product.Image3 = path;
                }
                else if (product.Image4 == null)
                {
                    product.Image4 = path;
                }
                else if (product.Image5 == null)
                {
                    product.Image5 = path;
                }
                else if (product.Image6 == null)
                {
                    product.Image6 = path;






                }



            }

                product.Category= form["ProductCategory"];
            product.Name = form["ProductIsim"];
            product.Fiyat = Convert.ToInt32(form["ProductFiyat"]);
            product.Toplam = form["ProductToplam"];
            product.Kod = form["ProductKodu"];
            product.Beden = form["ProductBeden"];


            productManager.Insert(product);

            return View("Creat");
            }   
        


        public ActionResult Creat()
        {




            return View();


        }

        public ActionResult List() {

            var product = productManager.List();
            
            
        return View(product);
        
        
        
        
        }
        public ActionResult Product_Detail() {











            return View();
                }

    }
   
  
}