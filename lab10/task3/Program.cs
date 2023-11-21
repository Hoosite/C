using System;
using System.IO;
using System.Collections.Generic;

public struct Toy
{
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public int MinAge { get; set; }
    public int MaxAge { get; set; }
}

public class ToyManager
{
    private const string FilePath = "toys.bin";
    private static List<Toy> toys;

    private static void CreateToy()
    {
        toys = new List<Toy>
        {
            new Toy { Name = "Мячик", Cost = 100.00m, MinAge = 4, MaxAge = 5 },
            new Toy { Name = "Мягкая игрушка", Cost = 557.75m, MinAge = 3, MaxAge = 6 },
            new Toy { Name = "Робот", Cost = 2000.00m, MinAge = 4, MaxAge = 5 },
            new Toy { Name = "Меч", Cost = 1000.00m, MinAge = 6, MaxAge = 11 },
            new Toy { Name = "Солдатик", Cost = 200.00m, MinAge = 7, MaxAge = 10 },
            new Toy { Name = "Игровой Компьютер", Cost = 60000.00m, MinAge = 10, MaxAge = 18 },
            new Toy { Name = "Танк Panzerkampfwagen V Panthe", Cost = 6000000.00m, MinAge = 18, MaxAge = 100 },
        };

        SaveToysToFile();
    }

    private static void SaveToysToFile()
    {
        try
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(FilePath, FileMode.Create)))
            {
                foreach (Toy toy in toys)
                {
                    writer.Write(toy.Name);
                    writer.Write(toy.Cost);
                    writer.Write(toy.MinAge);
                    writer.Write(toy.MaxAge);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ОШИБКА заполнения!  " + ex.Message);
        }
    }

    private static void LoadToysFromFile()
    {
        toys = new List<Toy>();

        try
        {
            using (BinaryReader reader = new BinaryReader(File.Open(FilePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Toy toy = new Toy
                    {
                        Name = reader.ReadString(),
                        Cost = reader.ReadDecimal(),
                        MinAge = reader.ReadInt32(),
                        MaxAge = reader.ReadInt32()
                    };
                    toys.Add(toy);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ОШИБКА ЧТЕНИЯ файла!" + ex.Message);
        }
    }

    public static List<string> GetToysForAgeRange(int minAge, int maxAge)
    {
        List<string> result = new List<string>();

        foreach (Toy toy in toys)
        {
            if (toy.MinAge <= maxAge && toy.MaxAge >= minAge)
            {
                result.Add(toy.Name);
            }
        }

        return result;
    }

    public static void Main()
    {
        CreateToy();

        LoadToysFromFile();

        List<string> toysForAgeRange = GetToysForAgeRange(4, 5);

        Console.WriteLine("Игрушки для детей возраста 4-5:");
        foreach (string toy in toysForAgeRange)
        {
            Console.WriteLine(toy);
        }
    }
}
