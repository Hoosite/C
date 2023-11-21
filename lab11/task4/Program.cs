using System;
using System.Collections.Generic;

class Alphabet
{
    public static int MissingLetters(string text)
    {
        HashSet<char> russianAlphabet = new HashSet<char>("абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray());

        text = text.ToLower();

        foreach (char symbol in text)
        {
            russianAlphabet.Remove(symbol);
        }

        return russianAlphabet.Count;
    }

    static void Main()
    {
        string text = "В медовом кипятке (Э, э), У наших приколов появится тень, Мечтают люди быть не фейк (Не фейк), Но по телику снова покажут фильм, где";
        // съешь же ещё этих мягких французских булок, да выпей чаю

        int missingLettersCount = MissingLetters(text);

        Console.WriteLine($"Количество букв русского алфавита, которые не встречаются в тексте: {missingLettersCount}");
    }
}
