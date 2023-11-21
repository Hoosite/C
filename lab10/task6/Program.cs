using System;
using System.IO;
using System.Text;

public static class TextFileProcessor
{
    public static void CopyLine(string sourceFilePath, string destinationFilePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(sourceFilePath);

            StringBuilder resultBuilder = new StringBuilder();

            foreach (string line in lines)
            {
                if (!Proverka(line))
                {
                    resultBuilder.AppendLine(line);
                }
            }

            File.WriteAllText(destinationFilePath, resultBuilder.ToString());

            Console.WriteLine("Операция выполнена успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    private static bool Proverka(string input)
    {
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        string sourceFilePath = "start.txt";
        string destinationFilePath = "finish.txt";

        TextFileProcessor.CopyLine(sourceFilePath, destinationFilePath);
    }
}
