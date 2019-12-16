using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using ConsoleTables;

namespace librarySystem
{
    class Book
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }

        public Book(string code,string name,string author,int stock)
        {
            Code = code;
            Name = name;
            Author = author;
            Stock = stock;
        }
        public void AddBook(int quantity)
        {
            Stock += quantity;
        }
        public void BorrowBook(int quantity)
        {
            Stock -= quantity;
        }
    }
}
