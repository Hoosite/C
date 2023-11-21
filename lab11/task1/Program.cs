using System;
using System.Collections.Generic;

class ListOperations
{
    public static List<T> NewList<T>(List<T> L1, List<T> L2)
    {
        List<T> result = new List<T>();

        foreach (var item in L1)
        {
            if (!L2.Contains(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    static void Main()
    {
        List<int> L1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> L2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> result = NewList(L1, L2);

        Console.WriteLine("Результат:");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
