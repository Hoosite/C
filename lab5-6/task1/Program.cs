using System;

class Program
{
    static void Main()
    {
        Square kvadrat = new Square("Квадрат");
        kvadrat.SetSide(5);

        Circle krug = new Circle("Круг");
        krug.SetRadius(3);

        kvadrat.Print();
        Console.WriteLine();
        krug.Print();
    }
}
