namespace Inheritance.TimeSpan;

public class Rectangle : Shape_c
{
    public double Length;

    public Rectangle(string color, double length) : base(color)
    {
        Length = length;
        Area = Length * Length;
    }
}
