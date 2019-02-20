using System.Collections.Generic;

namespace MathmaticalEquations
{
    public class HemisphereVolume : IMenuItem
    {
        private readonly string title = "Volume of a Hemisphere";
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
                var radius = AskForInput();
                var hemisphere = new Hemisphere(radius);
                display.SingleLine($"Your hemisphere has a volume of {hemisphere.Volume}", "PRESS ENTER TO CONTINUE");

            } while (AskAgain());
        }

        private double AskForInput()
        {
            var answer = display.Question("Please enter the radius of the hemisphere: ", "TYPE IN A VALUE | PRESS ENTER TO SUBMIT");

            if (double.TryParse(answer, out double result))
            {
                if (validate.PositiveNumber(result))
                {
                    return result;
                }

                display.SingleLine("Please enter a value greater than zero.", "PRESS ENTER TO CONTINUE");
                return AskForInput();
            }

            display.SingleLine("Please enter a number value", "PRESS ENTER TO CONTINUE");
            return AskForInput();
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
