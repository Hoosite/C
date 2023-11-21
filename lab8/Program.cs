using System;
using System.Collections.Generic;

class Figure
{
    protected char x;
    protected int y;

    public Figure(char x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public virtual void mov()
    {
        Console.WriteLine("Абстрактный метод mov для базовой фигуры.");
    }

    protected void PrintMove(char newX, int newY)
    {
        if (newX >= 'A' && newX <= 'H' && newY >= 1 && newY <= 8)
            Console.WriteLine($"{newX}{newY}");
    }
}

class Knight : Figure
{
    public Knight(char x, int y) : base(x, y) { }

    public override void mov()
    {
        Console.WriteLine("Возможные ходы для коня:");

        // Верхние и нижние движения
        PrintMove((char)(x - 1), y + 2);
        PrintMove((char)(x + 1), y + 2);
        PrintMove((char)(x - 1), y - 2);
        PrintMove((char)(x + 1), y - 2);

        // Левые и правые движения
        PrintMove((char)(x - 2), y + 1);
        PrintMove((char)(x + 2), y + 1);
        PrintMove((char)(x - 2), y - 1);
        PrintMove((char)(x + 2), y - 1);
    }
}

class Rook : Figure
{
    public Rook(char x, int y) : base(x, y) { }

    public override void mov()
    {
        Console.WriteLine("Возможные ходы для ладьи:");

        // Перемещение по вертикали и горизонтали
        for (char i = 'A'; i <= 'H'; i++)
        {
            if (i != x)
                PrintMove(i, y);
        }

        for (int i = 1; i <= 8; i++)
        {
            if (i != y)
                PrintMove(x, i);
        }
    }
}

class Program
{
    static void Main()
    {
        Knight knight = new Knight('H', 8);
        Rook rook = new Rook('A', 1);

        knight.mov();
        Console.WriteLine();
        rook.mov();
        Console.ReadLine();
    }
}
