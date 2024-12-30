using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Product
    { //1
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int price, int quantity)
        {
            if (price < 0)
            {
                throw new InvalidPriceException("Error, product with a negative price.");
            }

            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
