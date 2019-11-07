using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int month;
            int day;

            Console.Write("Enter your year: ");
            year = int.Parse(Console.ReadLine());

            while (year < 1971 || year > 2019)
            {
                Console.WriteLine("input correctly");
                year = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter your month: ");
            month = int.Parse(Console.ReadLine());

            while (month < 1 || month > 12)
            {
                Console.WriteLine("input correctly");
                month = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter your day: ");
            day = int.Parse(Console.ReadLine());

            while (day < 1 || day > 31)
            {
                Console.WriteLine("input correctly");
                day = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("your date is  " + year + "/" + month+"/" + day);
            Console.ReadKey();
        }
    }
}













            /*int inputYear()
            {
                if (year >= 1971 && year <= 2019)
                {
                    return year;
                }
                else
                {
                    Console.WriteLine("input correctly");
                }
                return 0;
            }

            Console.WriteLine(inputYear());

            /*int month;
            Console.Write("Enter your month: ");
            month = int.Parse(Console.ReadLine());

            if (month >= 1 && month <= 12)
            {
                Console.WriteLine("terminated");
            }
            else
            {
                Console.WriteLine("input correctly");
            }

            int day;
            Console.Write("Enter your day: ");
            day = int.Parse(Console.ReadLine());

            if (day <= 31)
            {

            }
            else
            {
                Console.WriteLine("input correctly");
            }

            Console.WriteLine("your date is " + day+"/" + month +"/" + year);
        }
    }
}
*/