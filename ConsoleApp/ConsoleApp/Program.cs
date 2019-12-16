using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
       /* {
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
}*/


{
            int year, month, date;
string str = "";
Console.WriteLine("Please enter year: ");
            while(true)
            {
                year = Convert.ToInt32(Console.ReadLine());
                if(year<1971 || year>2019) Console.WriteLine("Sorry, you provide an invalid year. Try again!");
                else break; 
            }
            Console.WriteLine("Please enter month: ");
            while (true)
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month< 1 || month> 12) Console.WriteLine("Sorry, you provide an invalid month. Try again!");
                else {
                    if (month == 1) str = "Jan";
                    else if (month == 2) str = "Feb";
                    else if (month == 3) str = "Mar";
                    else if (month == 4) str = "Apr";
                    else if (month == 5) str = "May";
                    else if (month == 6) str = "Jun";
                    else if (month == 7) str = "Jul";
                    else if (month == 8) str = "Aug";
                    else if (month == 9) str = "Sep";
                    else if (month == 10) str = "Oct";
                    else if (month == 11) str = "Nov";
                    else if (month == 12) str = "Dec";
                    break; 
                }
            }
            Console.WriteLine("Please enter day: ");
            while (true)
            {
                date = Convert.ToInt32(Console.ReadLine());
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (date< 1 || date> 31) Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                    else break;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (date< 1 || date> 30) Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                    else break;
                }
                else if (month == 2)
                {
                    if (date< 1 || date> 28) Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                    else break;
                }
            }
            //DateTime d = new DateTime(year,month,date);
            //Console.WriteLine("Your Date is: "+d);
            Console.WriteLine("Your Date is: "+date+"-"+str+"-"+year%100);
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