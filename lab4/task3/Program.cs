using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 17, 23, 57, 78, 674, 89, 127 };

        array = Remove7(array, 7);

        Console.WriteLine("Исходный массив после удаления элементов с цифрой 7: " + string.Join(", ", array));
    }

    static int[] Remove7(int[] array, int digit)
    {
        return array.Where(element => !Proverka(element, digit)).ToArray();
    }

    static bool Proverka(int number, int digit)
    {
        while (number != 0)
        {
            if (number % 10 == digit)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}
