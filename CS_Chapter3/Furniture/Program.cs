using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose P for Pine, O for Oak, or M for Mahogany: ");
            string input = Console.ReadLine();
            int price = 0;

            if (input == "P")
                price = 100;
            if (input == "O")
                price = 225;
            if (input == "M")
                price = 310;

            Console.WriteLine("The price is: {0}", price.ToString("C"));
        }
    }
}
