using System;
using Lab2;


internal class Program
{
    public static void Main(string[] args)
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(4, 0, "B");
        Point C = new Point(4, 3, "C");

        Figure myFigure = new Figure(A, B, C);

        myFigure.CalculatePerimeter();
    }
}
