using StoklamaBandi.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoklamaBandi.EntityFramework.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
            Database.SetInitializer<ProductContext>(null);
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
