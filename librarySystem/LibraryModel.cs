using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using ConsoleTables;

namespace librarySystem
{
    class LibraryModel : ILibrary
    {
        public IList<Book> _bookList;

        public LibraryModel()
        {
            _bookList= Database();
        }

        public IList<Book> Database()
        {
            string connectionString = "Server=FERTILE-FIELD\\SQLEXPRESS;Database=libraryDB;Integrated Security=True;";
            string sql = "SELECT * FROM Books";
            IList<Book> bookList = new List<Book>();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string code = reader["Code"].ToString();
                            string name = reader["Name"].ToString();
                            string author = reader["Author"].ToString();
                            int stock = Convert.ToInt32(reader["Stock"].ToString());
                            Book b = new Book(code, name, author, stock);
                            bookList.Add(b);
                        }
                        return bookList;
                    }
                }
            }
        }
        public void AddBook()
        {
            Console.WriteLine("enter book code : ");
            string code = Console.ReadLine();
            Console.WriteLine("enter book name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter author : ");
            string author = Console.ReadLine();
            Console.WriteLine("enter amount : ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Book b1 = new Book(code, name, author, stock);
            _bookList.Add(b1);

            string bookCode = b1.Code;
            string bookName = b1.Name;
            string bookAuthor = b1.Author;
            int bookStock = b1.Stock;

            string connectionString = "Server=FERTILE-FIELD\\SQLEXPRESS;Database=libraryDB;Integrated Security=True;";
            string sql = "INSERT INTO Books (Code,Name,Author,Stock) VALUES(@1bookCode,@2bookName,@3bookAuthor,@4bookStock);";

            var connection = new SqlConnection(connectionString);

            var command = new SqlCommand(sql, connection);
            var NameA = new SqlParameter("@1bookCode", System.Data.SqlDbType.VarChar, 15);
            var NameB = new SqlParameter("@2bookName", System.Data.SqlDbType.VarChar, 15);
            var NameC = new SqlParameter("@3bookAuthor", System.Data.SqlDbType.VarChar, 15);
            var NameD = new SqlParameter("@4bookStock", System.Data.SqlDbType.Int, 10);
            NameA.Value = bookCode;
            NameB.Value = bookName;
            NameC.Value = bookAuthor;
            NameD.Value = bookStock;
            command.Parameters.Add(NameA);
            command.Parameters.Add(NameB);
            command.Parameters.Add(NameC);
            command.Parameters.Add(NameD);

            connection.Open();
 
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("book added successfully");
            Console.ResetColor();

        }

        public void BorrowBook()
        {
            Console.WriteLine("enter book code : ");
            string borrowCode = Console.ReadLine();

            Book searchBook = _bookList.Where(x => x.Code.Trim() == borrowCode.Trim()).FirstOrDefault();

            if (searchBook != null)
            {
                Console.WriteLine("enter amount : ");
                int borrowStock = Convert.ToInt32(Console.ReadLine());
                if (borrowStock <= searchBook.Stock)
                {
                    var updateStock = searchBook.Stock -= borrowStock;

                    string connectionString = "Server=FERTILE-FIELD\\SQLEXPRESS;Database=libraryDB;Integrated Security=True;";
                    string sql = "UPDATE Books SET Stock = '" + updateStock + "' WHERE Code = '" + searchBook.Code + "'; ";

                    var connection = new SqlConnection(connectionString);
                    var command = new SqlCommand(sql, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    command.Dispose();
                    connection.Dispose();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("book borrowed successfully");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("insuffiucient stock ;");
                    Console.WriteLine("stock available : " + searchBook.Stock + " pc");
                }

            }
            else
            {
                Console.WriteLine("book is not available");
            }

        }

        public void ReturnBook()
        {
            Console.WriteLine("enter book code : ");
            string returnCode= Console.ReadLine();

            Book searchBook = _bookList.Where(x => x.Code == returnCode).FirstOrDefault();
            if (searchBook !=null)
            {
                Console.WriteLine("enter return Stock amount : ");
                int returnStock = Convert.ToInt32(Console.ReadLine());
                if (returnStock <= searchBook.Stock)
                {
                    var updateStock = searchBook.Stock += returnStock;

                    string connectionString = "Server=FERTILE-FIELD\\SQLEXPRESS;Database=libraryDB;Integrated Security=True;";
                    string sql = "UPDATE Books SET Stock = '" + updateStock + "' WHERE Code = '" + searchBook.Code + "'; ";

                    var connection = new SqlConnection(connectionString);
                    var command = new SqlCommand(sql, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    command.Dispose();
                    connection.Dispose();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("book successfully returned");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("icorrect amount");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("book code did not match");
                Console.ResetColor();
            }
        }

        public void Display()
        {
            string connectionString = "Server=FERTILE-FIELD\\SQLEXPRESS;Database=libraryDB;Integrated Security=True;";
            string sql = "SELECT * FROM Books";

            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(sql, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string code = reader["Code"].ToString();
                string name = reader["Name"].ToString();
                string author = reader["Author"].ToString();
                int stock = Convert.ToInt32(reader["Stock"].ToString());

                Console.WriteLine("code : " + code);
                Console.WriteLine("name : " + name);
                Console.WriteLine("author : " + author);
                Console.WriteLine("stock : " + stock + " pc");
                Console.WriteLine("===================================");

            }

        }

    }
}
