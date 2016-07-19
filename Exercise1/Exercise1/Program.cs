using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Let's guess the square root of numbers**");
            Console.WriteLine("Please enter a positive number: ");
            string userNumberInput = Console.ReadLine();
            double number = double.Parse(userNumberInput);
            Console.WriteLine("Please enter an error limit: ");
            string userErrorLimitInput = Console.ReadLine();
            double errorlimit = double.Parse(userErrorLimitInput);

            SquareRoot mySqrt = new SquareRoot(errorlimit);
            double result = mySqrt.ComputeSquareRoot(number);

            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();
        }
    }
}
