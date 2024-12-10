using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    internal class Program
    {
        static double SolveB(double x)
        {
            return Math.Sqrt(x); 
        }
        static double SolveA(double b, double c)
        {
            return Math.Pow(Math.Abs(b + c), 1.0 / 3.0);
        }

        static double SolveY(double a, double b)
        {
            return a * Math.Pow(Math.Sin(b), 2) + b * Math.Pow(Math.Cos(a), 2);
        }
            
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            double c = double.Parse(Console.ReadLine());

            double b = SolveB(x);
            double a = SolveA(b, c);
            double y = SolveY(a, b);

            Console.WriteLine($"The y value is : {y:F4}");
            Console.ReadLine();
        }
    }
}
