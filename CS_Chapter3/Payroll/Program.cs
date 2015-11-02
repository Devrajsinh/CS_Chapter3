using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hourly Pay Rate: ");
            double payRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            double grossPay = hours * payRate;
            double withtax = 0;
            double netPay = 0;

            if (grossPay <= 300)
                withtax = 0.1;
            else if (grossPay >= 300.1)
                withtax = 0.12;

            netPay = grossPay - (withtax * grossPay);
            Console.WriteLine("Gross pay: {0}\tWithholding tax: %{1}\tNET: {2}", grossPay.ToString("C"), (withtax*100), netPay.ToString("C"));
        }
    }
}
