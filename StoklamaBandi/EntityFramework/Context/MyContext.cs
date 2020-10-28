using StoklamaBandi.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoklamaBandi.EntityFramework.Context
{
    public class MyContext : DbContext
    {
        //public MyContext()
        //{
        //    Database.SetInitializer<MyContext>(null);
        //}

        public DbSet<ProductModel> Products { get; set; }

    }

}
