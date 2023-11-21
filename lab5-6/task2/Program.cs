using System;

abstract class AbstractFigure
{
    public abstract double Ploshad();
}


class Program
{
    static void Main()
    {
        Figure1 figure1 = new Figure1("Квадрат", 5);
        figure1.DisplayInfo();

        Figure2 figure2 = new Figure2("Прямоугольник", 4, 6);
        figure2.DisplayInfo();

        Figure3 figure3 = new Figure3("Параллелепипед", 3, 4, 5);
        figure3.DisplayInfo();
    }
}
