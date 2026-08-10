namespace Inheritance.TimeSpan;

public class Circle : Shape_c
{
    public double Radius;
    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
        Area = Math.PI * Radius * Radius;
    }
}
