using System.Collections.Generic;
using Utilities.ConsoleUI;

namespace MathmaticalEquations
{
    public class TriangleArea : IMenuItem
    {
        private readonly string title = "Area of a Triangle";
        private readonly int totalRows = 4;

        private Validator validate = new Validator();
        private Display display;

        public string Title()
        {
            return title;
        }

        public void Run()
        {
            do
            {
                display = new Display(title, totalRows);
                var sideA = AskForInput("A");
                var sideB = AskForInput("B");
                var sideC = AskForInput("C");

                if (IsValidTriangle(sideA, sideB, sideC))
                {
                    var triangle = new Triangle(sideA, sideB, sideC);
                    display.SingleLine($"Your triangle has an area of {triangle.Area}", "PRESS ENTER TO CONTINUE");
                }
                else
                {
                    display.SingleLine($"You have input an invalid triangle.", "PRESS ENTER TO CONTINUE");
                }

            } while (RunAgain());
        }

        private double AskForInput(string side)
        {
            var answer = display.Question($"Please enter side {side} of the triangle: ", "TYPE IN A VALUE | PRESS ENTER TO SUBMIT");

            if (double.TryParse(answer, out double result))
            {
                if (validate.PositiveNumber(result))
                {
                    return result;
                }

                display.SingleLine("Please enter a value greater than zero.", "PRESS ENTER TO CONTINUE");
                return AskForInput(side);
            }

            display.SingleLine("Please enter a number value", "PRESS ENTER TO CONTINUE");
            return AskForInput(side);
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private bool RunAgain()
        {
            var twoOptionList = new List<IMenuItem>
            {
                new Option("Yes"),
                new Option("No")
            };
            var twoOptionMenu = new Menu(twoOptionList, "Would you like to try again?");

            do
            {
                twoOptionMenu.Display();

            } while (twoOptionMenu.Selecting());

            return twoOptionMenu.CurrentSelection() == 0;
        }
    }
}