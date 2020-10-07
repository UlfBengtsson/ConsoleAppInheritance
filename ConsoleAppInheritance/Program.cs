using ConsoleAppInheritance.Model;
using ConsoleAppInheritance.Model.ExClasses;
using System;
using System.Collections.Generic;

namespace ConsoleAppInheritance
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }

        static string AskUserFor(string what)
        {
            Console.Write($"Please input {what}: ");
            return Console.ReadLine();
        }

        //----- exampel code methods ------------------------------

        void ExInheritance()
        {
            Pen pen = new Pen();

            pen.WriteToScreen("Hello World!");

            pen.SetColor("red");

            pen.WriteToScreen("Hello World!");

            WhiteBoardPen whiteBoardPen = new WhiteBoardPen();

            whiteBoardPen.WriteToScreen("Im a whitebord pen");

            whiteBoardPen.SetColor("red");

            whiteBoardPen.WriteToScreen("Im a red whitebord pen");

        }

        void Expoly()
        {
            Pen pen = new Pen();

            pen.SetColor("red");

            WhiteBoardPen whiteBoardPen = new WhiteBoardPen();

            whiteBoardPen.SetColor("red");

            whiteBoardPen.ImAWhiteBordPen();

            Pen wbPen = whiteBoardPen;

            //will not work - wbPen.ImAWhiteBordPen

            wbPen.WriteToScreen("Poly? yes but can only call on Pen members");
        }

        void ExPolyList()
        {
            Pen pen = new Pen();
            WhiteBoardPen whiteBoardPen = new WhiteBoardPen();

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

        void ExInterface()
        {
            List<IDanger> dangers = new List<IDanger>();

            dangers.Add(new Tool());
            dangers.Add(new Dog());
            //dangers.Add(new Cat());

            dangers[0].DangerInfo();

        }
    }
}
