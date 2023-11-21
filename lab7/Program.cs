using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string inputText = ("Вылетаю с поворота, на хвосте мигалки, Федералы травят, им меня не жалко, В камере тюремной, там, наверное, жарко, Я ещё молодой");

       // Используем регулярное выражение для извлечения слов из текста
        string[] words = Regex.Matches(inputText, @"\b\w+\b")
            .Cast<Match>()
            .Select(match => match.Value)
            .ToArray();

        if (words.Length == 0)
        {
            Console.WriteLine("Текст не содержит слов.");
            return;
        }

        string longestWord = words.OrderByDescending(w => w.Length).First();
        string shortestWord = words.OrderBy(w => w.Length).First();

        Console.WriteLine($"Самое длинное слово: {longestWord}");
        Console.WriteLine($"Самое короткое слово: {shortestWord}");

        // Меняем местами самое длинное и самое короткое слово
        inputText = Regex.Replace(inputText, @"\b" + longestWord + @"\b", "TEMP_PLACEHOLDER");
        inputText = Regex.Replace(inputText, @"\b" + shortestWord + @"\b", longestWord);
        inputText = Regex.Replace(inputText, "TEMP_PLACEHOLDER", shortestWord);

        Console.WriteLine("Текст после замены:");
        Console.WriteLine(inputText);
    }
}
