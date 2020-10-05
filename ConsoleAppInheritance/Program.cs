using ConsoleAppInheritance.Model;
using System;

namespace ConsoleAppInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();

            pen.WriteToScreen("Hello World!");

            pen.SetColor("red");

            pen.WriteToScreen("Hello World!");

            WhiteBoardPen whiteBoardPen = new WhiteBoardPen();

            whiteBoardPen.WriteToScreen("Im a whitebord pen");

            whiteBoardPen.SetColor("red");

            whiteBoardPen.WriteToScreen("Im a whitebord pen");
        }
    }
}
