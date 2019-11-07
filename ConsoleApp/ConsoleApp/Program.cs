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
                Console.WriteLine("sorry, you provide incorrect year");
                year = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter your month: ");
            month = int.Parse(Console.ReadLine());

            while (month < 1 || month > 12)
            {
                Console.WriteLine("sorry, you provide incorrect month");
                month = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter your day: ");
            day = int.Parse(Console.ReadLine());

            while (day < 1 || day > 31)
            {
                Console.WriteLine("sorry, you provide incorrect day");
                day = int.Parse(Console.ReadLine());
            }

            if (month == 2)
            {
                while (day > 28 || day < 1)
                {
                    Console.WriteLine("sorry, you provide incorrect day");
                    day = int.Parse(Console.ReadLine());
                };
            }

            if (month == 4 || month == 6 || month == 9 || month == 11 )
            {
                while (day > 30 || day < 1)
                {
                    Console.WriteLine("sorry, you provide incorrect day");
                    day = int.Parse(Console.ReadLine());
                };
            }

            else
            {
                while (day > 31 || day < 0)
                {
                    Console.WriteLine("sorry, you provide incorrect day");
                    day = int.Parse(Console.ReadLine());
                };
            }

            Convert.ToString(month);

            switch (month)
            {
                case 1:
                    Console.WriteLine("your date is  " + year + "/" + "jan" + "/" + day); ;
                    break;
                case 2:
                    Console.WriteLine("your date is  " + year + "/" + "feb" + "/" + day); 
                    break;
                case 3:
                    Console.WriteLine("your date is  " + year + "/" + "mar" + "/" + day); 
                    break;
                case 4:
                    Console.WriteLine("your date is  " + year + "/" + "apr" + "/" + day); ;
                    break;
                case 5:
                    Console.WriteLine("your date is  " + year + "/" + "may" + "/" + day); ;
                    break;
                case 6:
                    Console.WriteLine("your date is  " + year + "/" + "jun" + "/" + day); ;
                    break;
                case 7:
                    Console.WriteLine("your date is  " + year + "/" + "jul" + "/" + day); ;
                    break;
                case 8:
                    Console.WriteLine("your date is  " + year + "/" + "aug" + "/" + day); ;
                    break;
                case 9:
                    Console.WriteLine("your date is  " + year + "/" + "sep" + "/" + day); ;
                    break;
                case 10:
                    Console.WriteLine("your date is  " + year + "/" + "oct" + "/" + day); ;
                    break;
                case 11:
                    Console.WriteLine("your date is  " + year + "/" + "nov" + "/" + day); ;
                    break;
                case 12:
                    Console.WriteLine("your date is  " + year + "/" + "dec" + "/" + day); ;
                    break;
                default:
                    Console.WriteLine("input incorrectly") ;
                    break;
            }
            Console.ReadLine();
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