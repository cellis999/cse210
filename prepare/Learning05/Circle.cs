namespace Learning05;

class Circle : Shape
{
    private double radius;
    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        var area = 2 * 3.14 * radius;
        return area;
    }
}