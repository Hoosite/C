using System;


class Program
{
    static void Main()
    {
        int[] mas = { 1, 3, 5, 8, 5, 2, 8, 7 };

        Console.WriteLine("Исходный массив: " + string.Join(", ", mas));

        int newNumber = 777;

        int maxElement = mas.Max();

        var maximus = Enumerable.Range(0, mas.Length)
                                          .Where(i => mas[i] == maxElement)
                                          .ToArray();

        int maxIndex = maximus[0];

        InsertBeforeMax(mas, maxIndex, newNumber);

        Console.WriteLine("Измененный массив: " + string.Join(", ", mas));
    }

    static void InsertBeforeMax(int[] array, int index, int number)
    {
        for (int i = array.Length - 1; i > index; i--)
        {
            array[i] = array[i - 1];
        }

        array[index] = number;
    }
}
