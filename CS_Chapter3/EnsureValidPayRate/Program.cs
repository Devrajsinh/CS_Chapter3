using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your payrate?");
            double payRate = Convert.ToDouble(Console.ReadLine());
            double weeklyRate = payRate * 40;
            if (payRate < 5.65 || payRate > 49.99)
                Console.WriteLine("Error in pay rate");
            else
                Console.WriteLine("Payrate: {0}\tWeekly Payrate: {1}", payRate.ToString("C"), weeklyRate.ToString("C"));
            

        }
        
    }
}
