using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Pc";
            product1.Stock = 80;
            product1.Description = "Yeni dönem ürün";
         
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
        }
    }
}
