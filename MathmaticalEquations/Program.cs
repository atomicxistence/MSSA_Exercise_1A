using System.Collections.Generic;

namespace MathmaticalEquations
{
    class Program
    {
        public static List<IMenuItem> MenuItems { get; private set; }

        public static void Main()
        {
            InitializeClasses();

            do
            {
                Menu.Display();

            } while (Input.Selection());

            MenuItems[Input.SelectionItem].Run();
        }

        private static void InitializeClasses()
        {
            MenuItems = new List<IMenuItem>();

            var circleAreaCircumference = new CircleAreaCircumference();
            MenuItems.Add(circleAreaCircumference);

            var exit = new Exit();
            MenuItems.Add(exit);
        }
    }
}
