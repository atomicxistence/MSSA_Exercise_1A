using System;
using System.Collections.Generic;

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
                var triangle = new Triangle(sideA, sideB, sideC);
                display.SingleLine($"Your triangle has an area of {triangle.Area}", "PRESS ENTER TO CONTINUE");

            } while (AskAgain());
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

        private bool AskAgain()
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