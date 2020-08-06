using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Cources.Lesson10

{ 
 public abstract class Shape
{
  public int X;
  public int Y;
  public abstract double GetPerimeter();
  public virtual double GetArea()
  {
    return 0;
  }

  public void PrintShapeInfo()
  {
    Console.WriteLine($"Shape params is {X}, {Y}");
  }

}
public class Triangle : Shape
{
  public int A;
  public int B;
  public int C;

  public override double GetArea()
  {
    throw new NotImplementedException();
  }

  public override double GetPerimeter()
  {
    return A + B + C;
  }
}

public class Rectangle : Shape
{
  public int A { get; set; }
  public virtual int B { get; set; }

  public override double GetArea()
  {
    Console.WriteLine("Area of rectangle:");
    return A * B;
  }

  public override double GetPerimeter()
  {
    Console.WriteLine("Perimeter of rectangle:");
    return (A + B) * 2;
  }
}


public class Square : Rectangle
{
  public override int B
  {
    get { return A; }
    set { }
  }

  public Square(int a)
  {
    A = a;
  }
  public override double GetPerimeter()
  {
    Console.WriteLine("Perimeter of square:");
    return A * 4;
  }
  public override double GetArea()
  {
    Console.WriteLine("Area of square:");
    return Math.Pow(A, 2);
  }
}

public class Circle : Shape
{
  public double Radius { get; set; }
  public override double GetPerimeter()
  {
    return 2 * Radius * Math.PI;
  }

  public override double GetArea()
  {
    return Math.PI * Math.Pow(Radius, 2);
  }
}

class Program
{
  static void Main(string[] args)
  {

    var rectangle = new Rectangle() { A = 1, B = 3 };
    var rectangle1 = new Rectangle() { A = 2, B = 4 };
    var square = new Square(5);

    List<Rectangle> rectangles = new List<Rectangle>();
    rectangles.AddRange(new[] { rectangle, rectangle1, square });

    foreach (var r in rectangles)
    {
      Console.WriteLine($"Perimeter of shape is {r.GetPerimeter()}. \n Area of shape is {r.GetArea()}");
    }

    var circle = new Circle() { Radius = 2.3 };
    List<Shape> shapes = new List<Shape>() { rectangle, rectangle1, square, circle };

    foreach (var sh in shapes)
    {
      Console.WriteLine($"Perimeter of shape is {sh.GetPerimeter()}. \n Area of shape is {sh.GetArea()}");
    }
      Console.ReadLine();
    }    
}
}