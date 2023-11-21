using System;
using System.IO;

public class Matrix
{
    //заполняем бин файл случ. числами
    private static void RandomFillBin(string fileName, int count)
    {
        Random random = new Random();
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
        {
            for (int i = 0; i < count; i++)
            {
                writer.Write(random.Next());
            }
        }
    }

    // считывваем данные из бин. файла и заполняем матрицу
    private static int[,] RFileFMatrix(string fileName, int n)
    {
        int[,] matrix = new int[n, n];

        using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        matrix[i, j] = reader.ReadInt32();
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        return matrix;
    }

    // определяем столбец с максимальным количеством элементов, кратных сумме индексов
   private static int FindColumn(int[,] matrix)
{
    int maxColumn = 0;
    int maxCount = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            //проверка на ноль в знаменателе
            if (i + j != 0 && matrix[i, j] % (i + j) == 0)
            {
                count++;
            }
        }

        if (count > maxCount)
        {
            maxCount = count;
            maxColumn = j;
        }
    }

    return maxColumn + 1;
}
    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Reshenie(string fileName, int n)
    {
        RandomFillBin(fileName, n * n);

        int[,] matrix = RFileFMatrix(fileName, n);

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int maxColumn = FindColumn(matrix);

        Console.WriteLine($"Столбец с максимальным количеством элементов, кратных сумме индексов: {maxColumn}");
    }

    public static void Main()
    {
        string fileName = "data.bin";
        int n = 4; // выбираем размер матрицы

        Reshenie(fileName, n);
    }
}
