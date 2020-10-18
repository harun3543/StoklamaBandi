using StoklamaBandi.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoklamaBandi.EntityFramework.Entity
{
    [Table("Products")]
    public class ProductModel : IEntity
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

    }
}
