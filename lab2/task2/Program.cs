using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int sum = 0;

            for (int i = n; i <= 2 * n; i++)
            {
                sum += i * i;
            }

            Console.WriteLine($"Сумма n^2 + (n+1)^2 + ... + (2n)^2 равна {sum}");
        }
        else
        {
            Console.WriteLine("ОШИБКА!!! Введите натуральное число больше 0.");
        }
    }
}
