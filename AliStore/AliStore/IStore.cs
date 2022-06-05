using System;
using System.Collections.Generic;
using System.Text;

namespace AliStore
{
    internal interface IStore
    {
      
        public Product[] Products { get; set; }
        public int ProductLimit { get; set; }
        public double TotalIncome { get; set; }

         void AddProduct(Product product);

         void SellProduct(string No);
    }
}
