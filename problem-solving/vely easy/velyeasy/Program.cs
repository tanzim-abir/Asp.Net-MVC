using System;
using System.Text.RegularExpressions;

namespace velyeasy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Clear();
            }
            if (input < 1 && input > 20)
            {
                Console.WriteLine("wrond input");
            }
            else
            {
                while (input != 0)
                {
                    string s = Console.ReadLine();
                    var regex = new Regex("^[a-z]+$");

                    if (s.Length > 50 || !regex.IsMatch(s))

                    {
                        Console.WriteLine("char limit exceed or capital letter found");
                    }
                    else
                    {

                        if (s.Contains('r'))
                        {
                            Console.WriteLine("not vely easy");
                        }
                        else
                        {
                            Console.WriteLine("vely easy");
                        }
                    }

                    input--;
                }

            }
        }
    }
}

