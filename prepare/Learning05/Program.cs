using System;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Learning05;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 2);
        Rectangle rectangle = new Rectangle("blue", 4, 2);
        Circle circle = new Circle("green", 6);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (var item in shapes)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
        }
    }
}