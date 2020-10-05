using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritance.Model
{
    class WhiteBoardPen : Pen
    {

        public WhiteBoardPen() : base()
        {
            consoleColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
        }

    }
}
