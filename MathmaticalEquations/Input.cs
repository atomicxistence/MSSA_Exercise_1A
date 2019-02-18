using System;

namespace MathmaticalEquations
{
    public static class Input
    {
        public static int SelectionItem { get; private set; }

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

        public static bool Selection()
        {
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.Enter:
                    return false;
                case ConsoleKey.UpArrow:
                    if (SelectionItem == 0)
                    {
                        SelectionItem = Program.MenuItems.Count - 1;
                    } else 
                    { 
                        SelectionItem -= 1; 
                    }
                    return true;
                case ConsoleKey.DownArrow:
                    if (SelectionItem == Program.MenuItems.Count - 1)
                    {
                        SelectionItem = 0;
                    }
                    else
                    {
                        SelectionItem += 1;
                    }
                    return true;
                default:
                    return Selection();
            }
        }
    }
}
