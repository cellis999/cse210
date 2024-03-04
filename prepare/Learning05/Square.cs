using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Microsoft.VisualBasic;

namespace Learning05;

class Square : Shape
{
    private double side;
    public Square(string color, double side) : base(color)
    {
        this.side = side;
    }
    public override double GetArea()
    {
        var output = side * side;
        return output;
    }

}