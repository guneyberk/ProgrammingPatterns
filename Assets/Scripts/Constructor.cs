using System;

public interface IShape
{
    float CalculateArea();
}

public class Circle : IShape
{
    public float Radius { get; set; }

    public Circle(float radius)
    {
        Radius = radius;
    }

    public float CalculateArea()
    {
        return (float)(Math.PI * Radius * Radius);
    }
}

public class Rectangle : IShape
{
    public float Width { get; set; }
    public float Height { get; set; }

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public float CalculateArea()
    {
        return Width * Height;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IShape circle = new Circle(10);
        IShape rectangle = new Rectangle(4, 6);
    }
}




