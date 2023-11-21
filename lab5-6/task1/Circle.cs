using System;

public class Circle : Shape
{
    private double radius;

    public Circle(string name) : base(name)
    {
        radius = 0;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double value)
    {
        if (value > 0)
        {
            radius = value;
        }
        else
        {
            Console.WriteLine("Радиус должен быть положительным числом.");
        }
    }

    public double Ploshat()
    {
        return Math.PI * radius * radius;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Радиус: {radius}");
        Console.WriteLine($"Площадь: {Ploshat()}");
    }
}
