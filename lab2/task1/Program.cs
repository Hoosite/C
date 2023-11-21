using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            switch (n % 3)
            {
                case 0:
                    Console.WriteLine($"N = {n} = 3 * {(n / 3)}");
                    break;
                case 1:
                    Console.WriteLine($"N={n} = 3*{n / 3} + 1"); 
                    break;
                case 2:
                    Console.WriteLine($"N = {n} = 3*{n / 3} + 2");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите натуральное число.");
        }
    }
}
