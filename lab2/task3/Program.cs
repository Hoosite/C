using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
  
            Console.WriteLine("Решение с использованием цикла while:");
            UseWhile(x);

            Console.WriteLine("\nРешение с использованием цикла do..while:");
            UseDoWhile(x);

            Console.WriteLine("\nРешение с использованием цикла for:");
            UseFor(x);
        }
        else
        {
            Console.WriteLine("ОШИБКА!");
        }
    }

    static void UseWhile(double x)
    {
        int n = 0;
        double sum = 0;
        double resh;

        while (true)
        {
            resh = Factorial(n) / Factorial(2 * n);

            if (Math.Abs(resh) < x)
                break;

            sum += resh;
            n++;
        }

        Console.WriteLine($"Сумма членов ряда, модуль которых >= {x}, равна {sum}");
    }

    static void UseDoWhile(double x)
    {
        int n = 0;
        double sum = 0;
        double term;

        do
        {
            term = Factorial(n) / Factorial(2 * n);

            if (Math.Abs(term) < x)
                break;

            sum += term;
            n++;
        } while (true);

        Console.WriteLine($"Сумма членов ряда, модуль которых >= {x}, равна {sum}");
    }

    static void UseFor(double x)
    {
        double sum = 0;

        for (int n = 0; ; n++)
        {
            double term = Factorial(n) / Factorial(2 * n);

            if (Math.Abs(term) < x)
                break;

            sum += term;
        }

        Console.WriteLine($"Сумма членов ряда, модуль которых >= {x}, равна {sum}");
    }

    static double Factorial(int n)
    {
        if (n == 0)
            return 1;

        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
