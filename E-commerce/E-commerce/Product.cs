using System;
using System.Collections.Generic;
using System.Text;

namespace E_commerce
{
    class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

        public Product(string name,int stock,int price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }
        public void AddStock(int quantity)
        {
            Stock += quantity;
        }
        public void SoldStock(int quantity)
        {
            Stock -= quantity;
        }
    }
}
