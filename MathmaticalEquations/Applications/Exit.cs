using System;
using Utilities.ConsoleUI;

namespace MathmaticalEquations
{
    public class Exit : IMenuItem
    {
        private readonly string title = "Exit";

        public string Title()
        {
            return title;
        }

        public void Run()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
