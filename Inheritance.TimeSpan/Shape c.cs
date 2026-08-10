using System.Security.Cryptography.X509Certificates;

namespace Inheritance.TimeSpan;

public class Shape_c
{
    public string Color;
    public double Area;

    public Shape_c(string color)
    {
        Color = color;

    }
    public void GetInfo()
    {
        Console.WriteLine($"Color: {Color}, Area: {Area}");
    }

}
