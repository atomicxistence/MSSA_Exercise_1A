using System;

namespace MathmaticalEquations
{
    public static class Input
    {
        public static string Request(string message)
        {
            Console.Clear();
            Console.Write($"{message} ");
            return Console.ReadLine();
        }

        public static bool PositiveNumber(double input)
        {
            return input > 0;
        }
    }
}
