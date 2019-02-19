using System;

namespace MathmaticalEquations
{
    public class UserInput
    {
        public string Request(string message)
        {
            Console.Clear();
            Console.Write($"{message} ");
            return Console.ReadLine();
        }

        public bool PositiveNumber(double input)
        {
            return input > 0;
        }
    }
}
