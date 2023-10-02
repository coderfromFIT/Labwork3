using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






class Point
{
    private double x;
    private double y;
    private string label;

    public Point(double x, double y, string label)
    {
        this.x = x;
        this.y = y;
        this.label = label;
    }

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Label
    {
        get { return label; }
    }
}

class Figure
{
    private Point[] points;
    private string name;

    public Figure(string name, Point p1, Point p2, Point p3)
    {
        this.name = name;
        points = new Point[] { p1, p2, p3 };
    }

    public Figure(string name, Point p1, Point p2, Point p3, Point p4)
    {
        this.name = name;
        points = new Point[] { p1, p2, p3, p4 };
    }

    public Figure(string name, Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        this.name = name;
        points = new Point[] { p1, p2, p3, p4, p5 };
    }

    private double GetDistance(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public double GetSideLength(Point A, Point B)
    {
        return GetDistance(A, B);
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Name of the figure: {name}");
        Console.WriteLine($"Perimeter of the figure: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(0, 0, "A");
        Point p2 = new Point(0, 1, "B");
        Point p3 = new Point(1, 1, "C");

        Figure triangle = new Figure("Triangle", p1, p2, p3);
        triangle.CalculatePerimeter();

        
        Console.ReadLine();
    }
}
