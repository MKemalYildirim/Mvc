using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MultiKart.EntityLayer;

namespace MultiKart.DataAccessLayer.EntityFramework
{
  public class DatabaseContext : DbContext
    {
        public DbSet<AltMenu> AltMenu { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sidebar> Sidebar { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Solmenu> Solmenu { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
    


}
