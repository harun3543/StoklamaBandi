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
        public MyContext()
        {
            Database.SetInitializer<MyContext>(null);
        }

        public DbSet<ProductModel> Products { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        //    modelBuilder.Entity<ProductModel>().ToTable("Products");
        //}
    }

    public class MyDb : DataContext
    {
        public Table<ProductModel> ProductsModels;
        public MyDb(string connection) : base(connection) { }

    }
}
