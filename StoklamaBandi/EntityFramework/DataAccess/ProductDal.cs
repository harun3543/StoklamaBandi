using StoklamaBandi.Abstract;
using StoklamaBandi.EntityFramework.Context;
using StoklamaBandi.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.EntityFramework.DataAccess
{
    public class ProductDal : IRepositoryBase
    {
        //ProductContext context;
        ProductModel _product;
        public ProductDal(ProductModel product)
        {
            
        }

        public void Add(ProductModel productModel)
        {
            using (var context = new ProductContext())
            {
                context.Products.Add(new ProductModel
                {
                    ProductCode = productModel.ProductCode,
                    ProductName = productModel.ProductName
                });
            }
        }

        public void Delete(ProductModel productModel)
        {
            using (var context = new ProductContext())
            {
                context.Products.Remove(productModel);
                context.SaveChanges();
            }
        }

        public List<ProductModel> GetAll()
        {
            using (var context = new ProductContext())
            {
                var result = context.Products.ToList();
                return result;
            }
        }

        public IEnumerable<ProductModel> GetDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductModel productModel)
        {
            throw new NotImplementedException();
        }
    }
}
