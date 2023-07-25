using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPerformance
{
    public class ProductDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; } 
        public decimal BuyingPrice { get; set; }    
        public decimal SellingPrice { get; set; }    
        public int Quantity { get; set; }    
    }
}
