using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("input a number : ");
                int num = int.Parse(Console.ReadLine());
                int rev = 0;
                int b;

                //condition to check if the number is not 0
                while (num != 0)
                {
                    b = num % 10;        //extract a digit
                    rev = (rev * 10) + b;   //reverse the digits logic
                    num = num / 10;             //remained number
                }
                Console.WriteLine("The reverse of the number is: " + rev);

                {
                    int i, m = 0, flag = 0;

                    m = rev / 2;
                    for (i = 2; i <= m; i++)
                    {
                        if (rev % i == 0)
                        {
                            Console.Write("Number is not Prime.");
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine("Number is Prime.");
                }

            }

        }
    }
}
