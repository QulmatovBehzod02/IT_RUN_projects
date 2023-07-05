using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWharehouse
{
    public class Product
    {
        public Product(string productName, int quantity)
        {
            Name = productName;
            Quantity = quantity;

        }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} {Quantity}";
        }
    }
}
