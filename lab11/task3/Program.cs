using System;
using System.Collections.Generic;

class GroupAnalyzer
{
    private static HashSet<string> allMalls = new HashSet<string> { "ТРК «Семья»", "ТРЦ «Планета»", "ТРЦ «iMall ЭСПЛАНАДА»", "ПГГПУ"};

    //смотрим куда ходили все 
    public static HashSet<string> AllStudents(List<Student> students)
    {
        if (students == null || students.Count == 0)
        {
            throw new ArgumentException("Список студентов не может быть пустым.");
        }

        HashSet<string> mallsVisitedByAll = new HashSet<string>(students[0].VisitedMalls);

        foreach (var student in students)
        {
            mallsVisitedByAll.IntersectWith(student.VisitedMalls);
        }

        return mallsVisitedByAll;
    }

    // смотрим куда ходили некоторое
    public static HashSet<string> SomeStudents(List<Student> students)
    {
        if (students == null || students.Count == 0)
        {
            throw new ArgumentException("Список студентов не может быть пустым.");
        }

        HashSet<string> mallsVisitedBySome = new HashSet<string>(students[0].VisitedMalls);

        foreach (var student in students)
        {
            mallsVisitedBySome.UnionWith(student.VisitedMalls);
        }

        return mallsVisitedBySome;
    }

    // смотрим куда никто не ходил
    public static HashSet<string> NoOneStudent(List<Student> students)
    {
        if (students == null || students.Count == 0)
        {
            throw new ArgumentException("Список студентов не может быть пустым.");
        }

        HashSet<string> allMallsCopy = new HashSet<string>(allMalls);

        foreach (var student in students)
        {
            allMallsCopy.ExceptWith(student.VisitedMalls);
        }

        return allMallsCopy;
    }
}

class Student
{
    public string Name { get; set; }
    public HashSet<string> VisitedMalls { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Маландин Данил", VisitedMalls = new HashSet<string> { "ТРК «Семья»", "ТРЦ «Планета»" } },
            new Student { Name = "Зубов Сергей", VisitedMalls = new HashSet<string> { "ТРЦ «iMall ЭСПЛАНАДА»", "ТРК «Семья»" } },
            new Student { Name = "Карпенок Константин", VisitedMalls = new HashSet<string> { "ТРЦ «iMall ЭСПЛАНАДА»", "ТРК «Семья»" } },
            new Student { Name = "Глушенко Артём", VisitedMalls = new HashSet<string> { "ТРК «Семья»", "ТРЦ «Планета»" } },
        };

        // В какие ТРЦ из перечня ходили все студенты группы
        HashSet<string> mallsVisitedByAll = GroupAnalyzer.AllStudents(students);
        Console.WriteLine("ТРЦ, которые посетили все студенты: " + string.Join(", ", mallsVisitedByAll));

        // В какие ТРЦ из перечня ходили некоторые студенты группы
        HashSet<string> mallsVisitedBySome = GroupAnalyzer.SomeStudents(students);
        Console.WriteLine("ТРЦ, которые посетили некоторые студенты: " + string.Join(", ", mallsVisitedBySome));

        // В какие ТРЦ из перечня не ходил ни один из студентов группы
        HashSet<string> mallsNotVisitedByAny = GroupAnalyzer.NoOneStudent(students);
        Console.WriteLine("ТРЦ, которые не посетил ни один студент: " + string.Join(", ", mallsNotVisitedByAny));
    }
}
