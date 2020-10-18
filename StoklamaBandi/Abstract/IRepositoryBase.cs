using StoklamaBandi.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.Abstract
{
    public interface IRepositoryBase
    {
        void Add(ProductModel productModel);
        void Update(ProductModel productModel);
        void Delete(ProductModel productModel);
        List<ProductModel> GetAll();
        ProductModel GetDetails(int id);

    }
}
