using System;


public class Square : Shape
{
    private double side;

    public Square(string name) : base(name)
    {
        side = 0;
    }

    public double GetSide()
    {
        return side;
    }

    public void SetSide(double value)
    {
        if (value > 0)
        {
            side = value;
        }
        else
        {
            Console.WriteLine("Сторона должна быть положительным числом.");
        }
    }

    public double Ploshat()
    {
        return side * side;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Сторона: {side}");
        Console.WriteLine($"Площадь: {Ploshat()}");
    }
}
