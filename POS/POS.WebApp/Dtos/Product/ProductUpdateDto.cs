using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Dtos.Product
{
    public class ProductUpdateDto
    {
        public string Name { get; set; }
        public int ProductCategoryId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
