using System;

class Program
{
    static void Main()
    {
        int[] array = { 2, -3, 4, -5, 6, 7, 8, -9, 10, -10 };

        Console.WriteLine("Исходный массив:");
        MassivePrint(array);

        MassiveMod(array);

        Console.WriteLine("Измененный массив:");
        MassivePrint(array);
    }

    static void MassiveMod(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && arr[i] % 2 == 0)
            {
                arr[i] = 1;
            }
            else if (arr[i] < 0 && arr[i] % 2 != 0)
            {
                arr[i] = -1;
            }
        }
    }

    static void MassivePrint(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
