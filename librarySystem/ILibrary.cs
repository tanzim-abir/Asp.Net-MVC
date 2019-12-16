using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using ConsoleTables;

namespace librarySystem
{
    interface ILibrary
    {
        void AddBook();
        void BorrowBook();
        void ReturnBook();
        void Display();
        IList<Book> Database();
    }
}
