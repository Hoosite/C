using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        if (ulong.TryParse(Console.ReadLine(), out ulong number))
        {
            string binChis = ToBin(number);

            int BinCount = ToBinCount(binChis);

            Console.WriteLine($"Количество цифр в двоичной записи числа {number} равно {BinCount}");
        }
        else
        {
            Console.WriteLine("ОШИБКА!!!");
        }
    }

    static string ToBin(ulong num)
    {
        return Convert.ToString((long)num, 2);
    }

    // Функция для подсчета количества цифр в двоичной записи
    static int ToBinCount(string numi)
    {
        return numi.Length;
    }
}
