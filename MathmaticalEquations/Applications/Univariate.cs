using System;

namespace MathmaticalEquations
{
    public class Univariate
    {
        public double FirstAnswer { get; private set; }
        public double SecondAnswer { get; private set; }

        private double coefficientA;
        private double coefficientB;
        private double coefficientC;

        public Univariate(double a, double b, double c)
        {
            coefficientA = a;
            coefficientB = b;
            coefficientC = c;

            SolveEquation();
        }

        private void SolveEquation()
        {
            FirstAnswer = (-coefficientB + Math.Sqrt((coefficientB * coefficientB) - (4.0 * coefficientA * coefficientC))) / 2 * coefficientA;
            SecondAnswer = (-coefficientB - Math.Sqrt((coefficientB * coefficientB) - (4.0 * coefficientA * coefficientC))) / 2 * coefficientA;
        }
    }
}
