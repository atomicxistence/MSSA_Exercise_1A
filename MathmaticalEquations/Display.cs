using System;

namespace MathmaticalEquations
{
    public class Display
    {
        private string title;
        private string subtitle;
        private string selectionIndicator = $" ▶ ";

        private int screenWidth;
        private int screenHeight;
        private int totalRows;

        private int rowLength = GlobalVariables.rowLength;
        private ConsoleColor highlightColor = GlobalVariables.highlightColor;
        private ConsoleColor textColor = GlobalVariables.textColor;
        private ConsoleColor borderColor = GlobalVariables.borderColor;
        private ConsoleColor titleHighlightColor = GlobalVariables.titleHighlightColor;

        public Display(string title, int rows)
        {
            screenWidth = Console.WindowWidth;
            screenHeight = Console.WindowHeight;
            this.title = title;
            totalRows = rows;
        }

        public void MenuList(string subtitle)
        {
            this.subtitle = subtitle;

            Console.CursorVisible = false;
            PrintBorder();
            PrintSubtitle();
            PrintTitle();
        }

        public string Question(string question, string subtitle)
        {
            this.subtitle = subtitle;

            Console.CursorVisible = false;

            string answer = "";
            return answer;
        }

        public void Answer(string answer, string subtitle)
        {
            this.subtitle = subtitle;

            Console.CursorVisible = false;

        }

        private void PrintBorder()
        {
            Console.ForegroundColor = borderColor;

            //Top Border
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - totalRows / 2 - 1);
            PrintBorderedSpaceFill("-");
            //Bottom Border
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 + totalRows / 2 + 1);
            PrintBorderedSpaceFill("-");

            Console.ResetColor();
        }

        private void PrintEmptySpaceFill(int emptySpace)
        {
            for (int i = 0; i < emptySpace; i++)
            {
                Console.Write(" ");
            }
        }

        private void PrintBorderedSpaceFill(string borderType)
        {
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write(borderType);
            }
        }

        private void PrintTitle()
        {
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - totalRows / 2);
            Console.BackgroundColor = titleHighlightColor;
            Console.ForegroundColor = textColor;
            //variable to control the centering if the title is an odd number of characters
            var leftAlignCenter = (rowLength / 2) - (title.Length / 2);
            PrintEmptySpaceFill(leftAlignCenter);
            Console.Write(title);
            PrintEmptySpaceFill(rowLength - leftAlignCenter - title.Length);
            Console.ResetColor();
        }

        private int PrintSubtitle()
        {
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - totalRows / 2 + 1);
            Console.ForegroundColor = titleHighlightColor;
            var leftAlignCenter = (rowLength / 2) - (subtitle.Length / 2);
            PrintEmptySpaceFill(leftAlignCenter);
            Console.Write(subtitle);
            PrintEmptySpaceFill(rowLength - leftAlignCenter - subtitle.Length);
            Console.ResetColor();
            return leftAlignCenter;
        }

        public void PrintMenuItem(string itemName, bool isCurrentlySelected)
        {
            if (isCurrentlySelected)
            {
                Console.BackgroundColor = highlightColor;
                Console.ForegroundColor = textColor;
                Console.Write(selectionIndicator);
                Console.Write(itemName);
                PrintEmptySpaceFill(rowLength - (itemName.Length + selectionIndicator.Length));
                Console.ResetColor();
            }
            else
            {
                Console.Write(" ");
                Console.Write(itemName);
                PrintEmptySpaceFill(rowLength - itemName.Length);
            }
        }
    }
}
