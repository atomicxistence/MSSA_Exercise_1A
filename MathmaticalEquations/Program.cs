using System.Collections.Generic;

namespace MathmaticalEquations
{
    class Program
    {
        private static List<IMenuItem> menuItems = new List<IMenuItem>();
        private static Menu mainMenu;

        public static void Main()
        {
            InitializeClasses();

            while (true)
            {
                do
                {
                    mainMenu.Display();

                } while (mainMenu.Selecting());

                menuItems[mainMenu.CurrentSelection()].Run();
            }
        }

        private static void InitializeClasses()
        {
            var circleAreaCircumference = new CircleAreaCircumference();
            menuItems.Add(circleAreaCircumference);

            var hemisphereVolume = new HemisphereVolume();
            menuItems.Add(hemisphereVolume);

            var exit = new Exit();
            menuItems.Add(exit);

            mainMenu = new Menu(menuItems, "Mathmatical Equations");
        }
    }
}
