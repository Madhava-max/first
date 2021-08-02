using System;

namespace employee
{
    class Program
    {            
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int WAGE_PER_HOUR = 1000;
            int WORKING_HOURS = 8;
            int DAILYWAGE = 0;
            Random rand = new Random();
            int present = rand.Next(0, 2);
            if (present == IS_FULL_TIME)
            {
                Console.WriteLine("employee is present");
                Console.WriteLine("employee is happy");
                DAILYWAGE = WAGE_PER_HOUR * WORKING_HOURS;
                
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            Console.WriteLine("the daily wage is" + DAILYWAGE);
        }
    }
}
