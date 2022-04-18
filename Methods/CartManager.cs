using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name  + "added to cart");
        }
    }
}
