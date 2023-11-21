using System;

class Program
{
    static void Main()
    {
        // Пример исходного массива
        int[] array = { 5, 3, 8, 2, 8, 7, 1, 8 };

        // Определение количества максимальных элементов в массиве
        int maxCount = CountMaxElements(array);

        // Определение количества минимальных элементов в массиве
        int minCount = CountMinElements(array);

        // Вывод результата
        Console.WriteLine("Количество максимальных элементов: " + maxCount);
        Console.WriteLine("Количество минимальных элементов: " + minCount);
    }

    static int CountMaxElements(int[] array)
    {
        int max = array[0];
        int maxCount = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxCount = 1;
            }
            else if (array[i] == max)
            {
                maxCount++;
            }
        }

        return maxCount;
    }

    static int CountMinElements(int[] array)
    {
        int min = array[0];
        int minCount = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minCount = 1;
            }
            else if (array[i] == min)
            {
                minCount++;
            }
        }

        return minCount;
    }
}
