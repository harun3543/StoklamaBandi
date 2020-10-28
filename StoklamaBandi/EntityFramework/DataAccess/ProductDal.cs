using StoklamaBandi.Abstract;
using StoklamaBandi.EntityFramework.Context;
using StoklamaBandi.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoklamaBandi.EntityFramework.DataAccess
{
    public class ProductDal : IRepositoryBase 
    {
        
        public ProductDal()
        {
            
        }

        public void Add(ProductModel productModel)
        {
            using (var context = new MyContext())
            {
                var entity = context.Entry(productModel);
                entity.State = EntityState.Added;
                context.SaveChanges();
                //context.Products.Add(new ProductModel
                //{
                //    ProductCode = productModel.ProductCode,
                //    ProductName = productModel.ProductName
                //});
            }
        }

        public void Delete(ProductModel productModel)
        {
            using (var context = new MyContext())
            {
                var entity = context.Entry(productModel);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

                //context.Products.Remove(productModel);
                //context.SaveChanges();
            }
        }

        public List<ProductModel> GetAll()
        {
            using (var context = new MyContext())
            {
                var result = context.Products.ToList();
                return result;
            }
        }

        public ProductModel GetDetails(int id)
        {
            using (var context = new MyContext())
            {
                var result = context.Products.Where(p => p.ProductID == id).FirstOrDefault();
                return result;
            }
        }

        public void Update(ProductModel productModel)
        {
            using (var context = new MyContext())
            {
                var result = context.Entry(productModel);
                result.State = EntityState.Modified;
                context.SaveChanges();
                
            }
        }

    }
}
