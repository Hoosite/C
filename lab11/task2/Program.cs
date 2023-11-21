using System;
using System.Collections.Generic;

public class LinkedList1
{
    private static bool IsSymmetric(LinkedList<int> list)
    {
        var forwardEn = list.GetEnumerator();
        var backwardEn = list.Last;

        while (forwardEn.MoveNext() && backwardEn != null)
        {
            if (forwardEn.Current != backwardEn.Value)
            {
                return false;
            }

            backwardEn = backwardEn.Previous;
        }

        return true;
    }

    public static bool Proverka(LinkedList<int> list, int i, int j)
    {
        if (i < 0 || j >= list.Count || i >= j)
        {
            throw new ArgumentException("Некорректные параметры i и j");
        }

        //делаем временный список содержащий участок списка с i по j
        LinkedList<int> sublist = new LinkedList<int>(list.Skip(i).Take(j - i + 1));

        return IsSymmetric(sublist);
    }

    public static void Main()
    {
        LinkedList<int> myList = new LinkedList<int>(new[] { 1, 1, 1, 1, 2, 3, 5 });

        int i = 1;
        int j = 3;

        bool isSymmetric = Proverka(myList, i, j);

        Console.WriteLine($"Участок списка с {i} по {j} элемент симметричен: {isSymmetric}");
    }
}
