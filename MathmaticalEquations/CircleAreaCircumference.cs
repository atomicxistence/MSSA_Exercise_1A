using System;

namespace MathmaticalEquations
{
    public class CircleAreaCircumference : IMenuItem
    {
        private readonly string title = "Area and Circumference of a Circle";
        private UserInput input = new UserInput();

        public string Title()
        {
            return title;
        }

        public void Run()
        {
            bool tryAgain = false;

            do
            {
                var circle = new Circle(AskForRadius());

                Console.WriteLine();
                Console.WriteLine($"The area of your circle is {circle.Area}");
                Console.WriteLine($"The circumference of your circle is {circle.Circumference}");
                Console.ReadLine();

                tryAgain = input.Request("Would you like to try again? Y/N").ToUpper() == "Y";

            } while (tryAgain);
        }

        private double AskForRadius()
        {
            var userInput = input.Request("Please enter your circle's radius:");

            if (double.TryParse(userInput, out double result))
            {
                if (input.PositiveNumber(result))
                {
                    return result;
                }

                input.Request("Please enter a number greater than zero. Press ENTER to continue.");
                return AskForRadius();
            }

            input.Request("Please enter a number.  Press ENTER to continue.");
            return AskForRadius();
        }
    }
}
