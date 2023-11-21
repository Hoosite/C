using System;
using System.IO;

public class TextFileProcessor
{
    private static int[] ReadNumbersFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                if (int.TryParse(lines[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при чтении числа из строки: {lines[i]}");
                }
            }

            return numbers;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return null;
        }
    }

    public static double FindAverage(string filePath)
    {
        int[] numbers = ReadNumbersFromFile(filePath);

        if (numbers != null && numbers.Length > 0)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }
        else
        {
            return double.NaN;
        }
    }

    public static void Main()
    {
        string filePath = "file.txt";
        double average = FindAverage(filePath);

        if (!double.IsNaN(average))
        {
            Console.WriteLine($"Среднее арифметическое элементов файла: {average}");
        }
        else
        {
            Console.WriteLine("Не удалось найти среднее арифметическое. Пожалуйста, проверьте файл.");
        }
    }
}
