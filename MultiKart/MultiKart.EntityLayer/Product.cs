using MultiKart.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiKart.EntityLayer
{
    public partial class Product : MyEntityBase
    {
        
       
       
        public int Fiyat  { get; set; }

        public string Kod { get; set; }
        public string Beden { get; set; }

        public string Toplam { get; set; }

        public string Category { get; set; }


        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string Image6 { get; set; }










    }
  
}
