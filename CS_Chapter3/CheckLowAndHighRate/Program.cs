using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("What's your payrate?");
            int payRate = Convert.ToInt32(Console.ReadLine());
            if (payRate > 5.65 || payRate < 49.99)
                Console.WriteLine("Error in pay rate");
        }
    }
}
