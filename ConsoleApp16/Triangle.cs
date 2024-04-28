using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Triangle<T>
    {
        private T sideA;
        private T sideB;
        private T sideC;

        public Triangle(T a, T b, T c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public T SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public T SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public T SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Side A: {sideA}, Side B: {sideB}, Side C: {sideC}");
        }

        public double CalculateArea()
        {
            double a = Convert.ToDouble(sideA);
            double b = Convert.ToDouble(sideB);
            double c = Convert.ToDouble(sideC);

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return area;
        }
    }
}
