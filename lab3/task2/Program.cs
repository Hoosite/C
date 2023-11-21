using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текущее время (часы): ");
        if (int.TryParse(Console.ReadLine(), out int hours) && hours >= 0 && hours < 24)
        {
            Console.Write("Введите текущее время (минуты): ");
            if (int.TryParse(Console.ReadLine(), out int minutes) && minutes >= 0 && minutes < 60)
            {
                Console.Write("Введите текущее время (секунды): ");
                if (int.TryParse(Console.ReadLine(), out int seconds) && seconds >= 0 && seconds < 60)
                {
                    Console.Write("Введите количество минут (1<P<1000): ");
                    if (int.TryParse(Console.ReadLine(), out int P) && P > 1 && P < 1000)
                    {

                        NewTime(ref hours, ref minutes, ref seconds, P);
                        Console.WriteLine($"Новое время через {P} минут: {hours:D2}:{minutes:D2}:{seconds:D2}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода для P. Введите целое число, 1 < P < 1000.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода для секунд. Введите число от 0 до 59.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода для минут. Введите число от 0 до 59.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода для часов. Введите число от 0 до 23.");
        }
    }

    static void NewTime(ref int hours, ref int minutes, ref int seconds, int P)
    {
        int VseVMinute = hours * 60 + minutes + P;
        hours = VseVMinute / 60 % 24;
        minutes = VseVMinute % 60;

        seconds += P * 60;

        if (seconds >= 60)
        {
            minutes += seconds / 60;
            seconds %= 60;
        }

        if (minutes >= 60)
        {
            hours += minutes / 60;
            minutes %= 60;
        }
    }
}
