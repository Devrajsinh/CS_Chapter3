using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your gradepoint average?");
            double Average = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your admission test score?");
            int admission = Convert.ToInt32(Console.ReadLine());

            if (Average >= 3.0 && admission >= 60)
                Console.WriteLine("Accept");
            else if (admission >= 80)
                Console.WriteLine("Accept");
            else
                Console.WriteLine("Reject");
        }
    }
}
