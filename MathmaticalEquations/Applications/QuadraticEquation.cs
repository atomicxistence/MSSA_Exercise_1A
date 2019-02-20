using System.Collections.Generic;

namespace MathmaticalEquations
{
    public class QuadraticEquation : IMenuItem
    {
        private readonly string title = "Solving a Quadratic Equation";
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
                var coefficiantA = AskForInputCannotBeZero("A");
                var coefficiantB = AskForInput("B");
                var coefficiantC = AskForInput("C");
                var univariate = new Univariate(coefficiantA, coefficiantB, coefficiantC);
                display.DoubleLine("The answers to your quadratic equation are", $"{univariate.FirstAnswer} & {univariate.SecondAnswer}", "PRESS ENTER TO CONTINUE");

            } while (AskAgain());
        }

        private double AskForInputCannotBeZero(string coefficient)
        {
            var answer = display.Question($"Please enter coefficient {coefficient} of the equation: ", "TYPE IN A VALUE | PRESS ENTER TO SUBMIT");

            if (double.TryParse(answer, out double result))
            {
                if (validate.PositiveNumber(result))
                {
                    return result;
                }

                display.SingleLine("Please enter a value greater than zero.", "PRESS ENTER TO CONTINUE");
                return AskForInputCannotBeZero(coefficient);
            }

            display.SingleLine("Please enter a number value", "PRESS ENTER TO CONTINUE");
            return AskForInputCannotBeZero(coefficient);
        }

        private double AskForInput(string coefficient)
        {
            var answer = display.Question($"Please enter coefficient {coefficient} of the equation: ", "TYPE IN A VALUE | PRESS ENTER TO SUBMIT");

            if (double.TryParse(answer, out double result))
            {
                if (validate.GreaterThanOrEqualToZero(result))
                {
                    return result;
                }

                display.SingleLine("Please enter a value equal to or greater than zero.", "PRESS ENTER TO CONTINUE");
                return AskForInput(coefficient);
            }

            display.SingleLine("Please enter a number value", "PRESS ENTER TO CONTINUE");
            return AskForInput(coefficient);
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