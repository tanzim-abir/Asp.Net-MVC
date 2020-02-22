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
                while(totalMember!=0)
            }
        }
    }
}
