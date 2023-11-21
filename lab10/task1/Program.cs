using System;
using System.IO;

public static class BinFile
{
    private static Random random = new Random();

    private static void FillRandomData(string filePath, int count)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            for (int i = 0; i < count; i++)
            {
                int randomValue = random.Next(int.MinValue, int.MaxValue);
                writer.Write(randomValue);
            }
        }
    }

    private static int FindMaxComponent(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int maxAbsoluteValue = int.MinValue;
            
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                int componentValue = reader.ReadInt32();
                int componentNumber = reader.ReadInt32();

                if (componentNumber % 2 != 0)
                {
                    int absoluteValue = Math.Abs(componentValue);
                    if (absoluteValue > maxAbsoluteValue)
                    {
                        maxAbsoluteValue = absoluteValue;
                    }
                }
            }

            return maxAbsoluteValue;
        }
    }

    public static void Reshenie(string filePath, int componentCount)
    {
        FillRandomData(filePath, componentCount);

        int result = FindMaxComponent(filePath);

        Console.WriteLine($"Наибольшее из значений модулей компонент с нечетными номерами: {result}");
    }
}

class Program
{
    static void Main()
    {
        string filePath = "data.bin";
        int componentCount = 10; // Задайте необходимое количество компонент

        BinFile.Reshenie(filePath, componentCount);
    }
}
