using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите отрезок [a, b], на котором f(a) * f(b) < 0:");
        Console.Write("a = ");
        if (double.TryParse(Console.ReadLine(), out double a))
        {
            Console.Write("b = ");
            if (double.TryParse(Console.ReadLine(), out double b) && b > a)
            {
                Console.Write("Введите точность c (c > 0): ");
                if (double.TryParse(Console.ReadLine(), out double c) && c > 0)
                {

                    double root = Root(a, b, c);
                    Console.WriteLine($"Корень уравнения f(x) = 0 с точностью {c} на отрезке [{a}, {b}] равен {root}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода для точности c. Введите положительное число.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода для b. Введите число больше a.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода для a.");
        }
    }

    // ищем корнень путем деление отрезка пополам
    static double Root(double a, double b, double c)
    {
        double fa = FunctionValue(a);
        double fb = FunctionValue(b);

        if (Math.Abs(b - a) < c)
        {
            return (a + b) / 2;
        }

        double mid = (a + b) / 2;
        double fmid = FunctionValue(mid);

        //выбор подотрезка на котором смена знака
        if ((fa * fmid) < 0)
        {
            // смена на левом подотрезке
            return Root(a, mid, c);
        }
        else
        {
            // на правом
            return Root(mid, b, c);
        }
    }

    // функция f(x) = x^2 - 4
    static double FunctionValue(double x)
    {
        return x * x - 4;
    }
}
