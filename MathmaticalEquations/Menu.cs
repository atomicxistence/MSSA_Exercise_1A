using System;
using System.Collections.Generic;

namespace MathmaticalEquations
{
    public static class Menu
    {
        private static int screenWidth;
        private static int screenHeight;
        private static int totalRows;

        private static readonly string title = "Mathmatical Equations";
        private static readonly int rowLength = 40;
        private static readonly int defaultRows = 3;

        private static readonly ConsoleColor highlightColor = ConsoleColor.Cyan;
        private static readonly ConsoleColor textColor = ConsoleColor.Black;
        private static readonly ConsoleColor borderColor = ConsoleColor.DarkCyan;
        private static readonly ConsoleColor titleHighlightColor = ConsoleColor.DarkMagenta;

        public static void Display()
        {
            Console.CursorVisible = false;

            SetScreenDimensions();
            PrintBorder();
            PrintTitle();
            PrintMenuItems(); 
        }

        private static void SetScreenDimensions()
        {
            screenWidth = Console.WindowWidth;
            screenHeight = Console.WindowHeight;
            totalRows = Program.MenuItems.Count + defaultRows;
        }

        private static void PrintBorder()
        {
            Console.ForegroundColor = borderColor;

            //Top Border
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2 - 1, screenHeight / 2 - totalRows / 2 - 1);
            PrintBorderedSpaceFill("-");
            //Bottom Border
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2 - 1, screenHeight / 2 + totalRows / 2 + 1);
            PrintBorderedSpaceFill("-");

            Console.ResetColor();
        }

        private static void PrintTitle()
        {
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - totalRows / 2);
            Console.BackgroundColor = titleHighlightColor;
            Console.ForegroundColor = textColor;
            PrintEmptySpaceFill(title.Length);
            Console.Write(title);
            PrintEmptySpaceFill(title.Length);
            Console.ResetColor();
        }

        private static void PrintMenuItems()
        {
            for (int i = 0; i < Program.MenuItems.Count; i++)
            {
                var yOffset = i + defaultRows;
                Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - totalRows / 2 + yOffset);
                if (Input.SelectionItem == i)
                {
                    Console.BackgroundColor = highlightColor;
                    Console.ForegroundColor = textColor;
                    Console.Write(Program.MenuItems[i].Title());
                    PrintEmptySpaceFill(Program.MenuItems[i].Title().Length);
                    Console.ResetColor();
                }else 
                {
                    Console.Write(Program.MenuItems[i].Title());
                    PrintEmptySpaceFill(Program.MenuItems[i].Title().Length);
                }

            }
        }

        private static void PrintEmptySpaceFill(int nonEmptySpace)
        {
            for (int i = 0; i < (rowLength - nonEmptySpace) / 2; i++)
            {
                Console.Write(" ");
            }
        }

        private static void PrintBorderedSpaceFill(string borderType)
        {
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write(borderType);
            }
        }

    }
}
