namespace Lab2;

public class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.point1 - A.point1, 2) + Math.Pow(B.point2 - A.point2, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0.0;
        for (int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length; 
            perimeter += GetSideLength(points[i], points[nextIndex]);
        }
        Console.WriteLine("Perimeter: " + perimeter);
    }
}
