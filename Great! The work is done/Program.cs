using System;

namespace Great_work__has_done
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total hours to finish the sprint");
            int sprintHour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total team member");
            int totalMember = Convert.ToInt32(Console.ReadLine());

            if (sprintHour <= 0 || sprintHour > 100 || totalMember <= 0 || totalMember > 100)
            {
                Console.WriteLine("wrong input");
            }
            else
            {
                int sum = 0;

                for (int i = 0; i < totalMember; i++)
                {
                    int workHour = Convert.ToInt32(Console.ReadLine());

                    if (workHour < 24 || workHour > 0)
                    {
                        sum += workHour;
                    }
                    else
                    {
                        Console.WriteLine("wrong input");
                    }
                }
                if(sum < 0)
                {
                    Console.WriteLine("project will finish within 1 day");
                }
                else
                {
                    int day = sprintHour / sum;
                    Console.WriteLine("project will finish within "+day+" days");
                }
            }
        }
    }
}
