using System;

namespace MathmaticalEquations
{
    class Program
    {
        public static void Main()
        {
            bool tryAgain = false;

            do
            {
                var circle = new Circle(AskForRadius());

                Console.WriteLine();
                Console.WriteLine($"The area of your circle is {circle.Area}");
                Console.WriteLine($"The circumference of your circle is {circle.Circumference}");
                Console.ReadLine();

                tryAgain = Input.Request("Would you like to try again? Y/N").ToUpper() == "Y";

            } while (tryAgain);


            Environment.Exit(0);
        }

        private static double AskForRadius()
        {
            var input = Input.Request("Please enter your circle's radius: ");

            if (double.TryParse(input, out double result))
            {
                if (Input.PositiveNumber(result))
                {
                    return result;
                }

                Input.Request("Please enter a number greater than zero. Press ENTER to continue.");
                return AskForRadius();
            }

            Input.Request("Please enter a number.  Press ENTER to continue.");
            return AskForRadius();
        }
    }
}
