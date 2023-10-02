using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rectangle
{
    // field of class
    private double side1;
    private double side2;

    // constructor class
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    
    public double CalculateArea()
    {
        return side1 * side2;
    }

    
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    
    public double Area
    {
        get { return CalculateArea(); }
    }

    
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        
        Console.Write("Inpute first length : ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Inpute second lenght 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Create rectangle class
        Rectangle rectangle = new Rectangle(side1, side2);

        
        Console.WriteLine($"perimeter of a rectangle: {rectangle.Perimeter}");
        Console.WriteLine($"Square of a rectangle: {rectangle.Area}");

        Console.ReadLine(); 
    }
}