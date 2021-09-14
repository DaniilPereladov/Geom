
using CoreLib;
using CoreLib.Shapes.Lines;
using System;
using static System.Console;
namespace TestAppcmd
{
    class Program
    {
        static void Main(string[] args)
        {
            IDraw line1 = new HorizontalLine(5, 10, 2),
                 line2 = new VerticalLine(3, 2, 6);
            line1.Draw();
            line2.Draw();
            ReadKey();
        }
    }
}
