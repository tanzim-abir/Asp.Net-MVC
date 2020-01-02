using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_commerce
{
    class EcoModel:IEco
    {
        public IList<Product> _ProductList;
        public IList<Product> _CustomersProductList;

        public EcoModel()
        {
            IList<Product> ProductList = new List<Product>();
            _ProductList = ProductList;

            IList<Product> CustomersProductList = new List<Product>();
            _CustomersProductList = CustomersProductList;
        }
        public void AddProduct()
        {
            Console.WriteLine("Enter product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter amount : ");
            int stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price : ");
            int price = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(name,stock,price);
            _ProductList.Add(product);
            _CustomersProductList.Add(product);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("product added successfully");
            Console.ResetColor();

        }

        public void BuyProduct()
        {
            Console.WriteLine("Enter product name : ");
            string productName = Console.ReadLine();

            Product searchProduct = _ProductList.Where(x => x.Name.Trim() == productName.Trim()).FirstOrDefault();

            if (searchProduct != null)
            {
                Console.WriteLine("Enter amount : ");
                int BuyStock = Convert.ToInt32(Console.ReadLine());
                if (BuyStock <= searchProduct.Stock)
                {
                    var updateStock = searchProduct.Stock -= BuyStock;

                    _CustomersProductList.Remove(searchProduct);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Product brought successfully");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("insuffiucient stock ;");
                    Console.WriteLine("stock available : " + searchProduct.Stock + " pc");
                }

            }
            else
            {
                Console.WriteLine("Product is not available");
            }

        }

        public void Display()
        {
            foreach(var item in _ProductList)

            Console.WriteLine("Product Name: " + item.Name+" ; Product in Stock: "+item.Stock+" ; Product Price: "+item.Price);
            Console.WriteLine("===================================");

        }
        public void DisplayCustomersProduct()
        {
            Console.WriteLine("Customer's product List");
            foreach (var item in _CustomersProductList)
            {
                Console.WriteLine("Product Name: " + item.Name + " ; Product in Stock: " + item.Stock+" ; Product Price: "+item.Price);
            }
        }

    }

}
