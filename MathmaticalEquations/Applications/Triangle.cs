using System;

namespace MathmaticalEquations
{
    public class Triangle
    {
        public double Area { get; private set; }

        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;

            SetArea();
        }

        private void SetArea()
        {
            var p = (sideA + sideB + sideC) / 2.0;
            Area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
