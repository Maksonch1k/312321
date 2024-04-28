using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int
            Triangle<int> intTriangle = new Triangle<int>(3, 4, 5);
            Console.WriteLine("Triangle with sides of type int:");
            intTriangle.DisplayInfo();
            Console.WriteLine($"Area: {intTriangle.CalculateArea()}");

            //  double
            Triangle<double> doubleTriangle = new Triangle<double>(5.5, 6.5, 7.5);
            Console.WriteLine("\nTriangle with sides of type double:");
            doubleTriangle.DisplayInfo();
            Console.WriteLine($"Area: {doubleTriangle.CalculateArea()}");

            // uint
            Triangle<uint> uintTriangle = new Triangle<uint>(2, 3, 4);
            Console.WriteLine("\nTriangle with sides of type uint:");
            uintTriangle.DisplayInfo();
            Console.WriteLine($"Area: {uintTriangle.CalculateArea()}");
        }
    }
    }

