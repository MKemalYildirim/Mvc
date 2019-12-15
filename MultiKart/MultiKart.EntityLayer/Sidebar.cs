using MultiKart.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiKart.EntityLayer 
{

    public partial class Sidebar : MyEntityBase
    {
        


        public virtual List<AltMenu> Altmenu { get; set; }
    }
    
}
