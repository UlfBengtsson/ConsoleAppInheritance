using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritance.Model
{
    //    Child           Parent
    class WhiteBoardPen : Pen
    {

        public WhiteBoardPen() : base()
        {
            consoleColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
        }

        public new void WriteToScreen(string text)// override with the new keyword
        {
            Console.ForegroundColor = consoleColor;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine(text);

            Console.ResetColor();
        }
    }
}
