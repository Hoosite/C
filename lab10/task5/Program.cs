using System;
using System.IO;

public static class FileProcessor
{
    private static string FilePath = "file.txt";

    private static int[] ReadNumbersFromFile()
    {
    string[] lines = File.ReadAllLines(FilePath);

    //разбивка строк в массив
    int[] numbers = lines.SelectMany(line => line.Split(' ')).Select(int.Parse).ToArray();

    return numbers;
    }



    private static long Calculated(int[] numbers)
    {
        long product = 1;

        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                product *= num;
            }
        }

        return product;
    }

    public static long Reshenie()
    {
        try
        {
            int[] numbers = ReadNumbersFromFile();
            long result = Calculated(numbers);
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка!!: {ex.Message}");
            return -1;
        }
    }
}

class Program
{
    static void Main()
    {
        long product = FileProcessor.Reshenie();

        if (product != -1)
        {
            Console.WriteLine($"Произведение нечётных элементов в файле: {product}");
        }

        Console.ReadLine();
    }
}
