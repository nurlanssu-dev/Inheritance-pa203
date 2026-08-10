namespace Inheritance.TimeSpan;

public class Product
{
    public string Name;
    public decimal Price;
    public int Count;

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Detail()
    {
        return $"Name: {Name}, Price: {Price}, Count: {Count}";
    }
    public decimal Discount(int discountRate)
    {
        return Price - Price * discountRate / 100;
    }

}
