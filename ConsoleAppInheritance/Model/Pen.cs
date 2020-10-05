using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritance.Model
{
    public class Pen
    {
        protected ConsoleColor consoleColor;
        protected string color;
        public string Color { get { return color; } }

        public Pen()
        {
            consoleColor = ConsoleColor.White;
        }


        public void WriteToScreen(string text)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void SetColor(string color)
        {
            switch (color.ToLower())
            {
                case "röd":
                case "red":
                    consoleColor = ConsoleColor.Red;
                    break;
                //... more colors
                default:
                    consoleColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
