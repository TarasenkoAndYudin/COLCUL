using System;
using Calculation;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculationLib.Plus(10, 5));
            Console.WriteLine(CalculationLib.Minus(10, 5));
            Console.WriteLine(CalculationLib.Divide(10, 5));
            Console.WriteLine(CalculationLib.Multiply(10, 5));
        }
    }
}
