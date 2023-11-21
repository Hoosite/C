using System;

public class Shape
{
    private string name;

    public Shape(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void Print()
    {
        Console.WriteLine($"Фигура: {name}");
    }
}
