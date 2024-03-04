using System.Formats.Asn1;

namespace Learning05;

class Rectangle : Shape
{
    private double side1;
    private double side2;
    public Rectangle(string color, double side1, double side2) : base(color)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public override double GetArea()
    {
        var area = side1 * side2;
        return area;
    }
}