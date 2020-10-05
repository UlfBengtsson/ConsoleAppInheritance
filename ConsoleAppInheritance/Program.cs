using ConsoleAppInheritance.Model;
using System;
using System.Collections.Generic;

namespace ConsoleAppInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();

            //pen.WriteToScreen("Hello World!");

            pen.SetColor("red");

            //pen.WriteToScreen("Hello World!");

            WhiteBoardPen whiteBoardPen = new WhiteBoardPen();

            //whiteBoardPen.WriteToScreen("Im a whitebord pen");

            whiteBoardPen.SetColor("red");

            //whiteBoardPen.WriteToScreen("Im a whitebord pen");

            whiteBoardPen.ImAWhiteBordPen();

            Pen wbPen = whiteBoardPen;

            //will not work - wbPen.ImAWhiteBordPen

            //wbPen.WriteToScreen("Poly?");

            List<Pen> penBox = new List<Pen>();

            penBox.Add(pen);
            penBox.Add(whiteBoardPen);


            foreach (var item in penBox)
            {
                Console.ResetColor();

                if (item is WhiteBoardPen)
                {
                    (item as WhiteBoardPen).WriteToScreen("whitebord pen text");
                    (item as WhiteBoardPen).ImAWhiteBordPen();
                }
                else
                {
                    item.WriteToScreen("normal pen text");
                }
            }

        }
    }
}
