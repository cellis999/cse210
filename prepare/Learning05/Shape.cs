using System.Drawing;
using System.Runtime.InteropServices.Marshalling;

namespace Learning05;

class Shape
{
    private string color;
    public Shape(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return $"{color}";
    }

    private void SetColor()
    {

    }

    virtual public double GetArea()
    {
        return 1;
    }
}