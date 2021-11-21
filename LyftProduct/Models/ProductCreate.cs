using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyftProduct.Models
{
    public class ProductCreate
    {
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public string ProductImage { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
