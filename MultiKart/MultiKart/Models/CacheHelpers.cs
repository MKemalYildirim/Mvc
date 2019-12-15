using MultiKart.BusinessLayer;
using MultiKart.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace MultiKart.Models
{
    public class CacheHelper
    {
        public static List<Sidebar> GetSidebars() 
        {
            var result = WebCache.Get("Sidebar-cache");

            if (result == null)
            {

                SidebarManager manager = new SidebarManager();
                result = manager.List();

                WebCache.Set("Sidebar-cache", result, 20, true);
            }

            return result;
        }
      
        public static List<Solmenu> GetSolmenus()
        {
            var result = WebCache.Get("Solmenu-Cache");

            if (result == null)
            {

                SolMenuManager manager = new SolMenuManager();
                result = manager.List();

                WebCache.Set("Solmenu-cache", result, 20, true);
            }

            return result;
        }
        public static List<Slider> GetSliders()
        {
            var result = WebCache.Get("Slider-cache");

            if (result == null)
            {

                SliderManager manager = new SliderManager();
                result = manager.List();

                WebCache.Set("Slider-cache", result, 20, true);
            }

            return result;
        }
        public static List<Product> GetProducts()
        {
            var result = WebCache.Get("Product-cache");

            if (result == null)
            {

                ProductManager manager = new ProductManager();
                result = manager.List();

                WebCache.Set("Product-cache", result, 20, true);
            }

            return result;
        }
        public static List<AltMenu> GetAltMenus()
        {
            var result = WebCache.Get("AltMenu-cache");

            if (result == null)
            {

                AltMenuManager manager = new AltMenuManager();
                result = manager.List();

                WebCache.Set("AltMenu-cache", result, 20, true);
            }

            return result;
        }
  
   

           
        }


    }
