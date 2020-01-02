using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace E_commerce
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the store");
            Console.WriteLine("=========[/[ ]\\]=========");
            Console.WriteLine("");

            EcoModel ecommerce = new EcoModel();

            Console.WriteLine("============================");
            while (true)
            {
                Console.WriteLine("Select an option");
                Console.WriteLine("1 : Add product");
                Console.WriteLine("2 : Buy product");
                Console.WriteLine("3 : Display customer's product list");
                Console.WriteLine("4 : Display product list");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    ecommerce.AddProduct();
                }
                else if (option == 2)
                {

                    ecommerce.BuyProduct();
                }

                else if (option == 3)
                {
                    ecommerce.DisplayCustomersProduct();
                }
                else if (option == 4)
                {
                    ecommerce.Display();
                }
            }
        }
    }
}