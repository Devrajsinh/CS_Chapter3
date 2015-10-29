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
            int Average = Convert.ToInt32(Console.ReadLine());
            if (Average > 3.0 || payRate < 3.0)
                Console.WriteLine("Reject");
        }
    }
}
