using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using ConsoleTables;

namespace librarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the library");
            Console.WriteLine("=========[/[ ]\\]=========");
            Console.WriteLine("");

            LibraryModel library = new LibraryModel();

            Console.WriteLine("============================");
            while (true)
            {
                Console.WriteLine("select an option");
                Console.WriteLine("1 : add book");
                Console.WriteLine("2 : borrow book");
                Console.WriteLine("3 : return book");
                Console.WriteLine("4 : display book");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    library.AddBook();
                }
                else if (option == 2)
                {
 
                    library.BorrowBook();
                }

                else if (option == 3)
                {
                    library.ReturnBook();
                }
                else if (option == 4)
                {
                    library.Display();
                }
            }
        }
    }
}
