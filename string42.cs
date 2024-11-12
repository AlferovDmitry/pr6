using System;

class Program
{
    static void Main()
    {
        // Ввод строки
        Console.WriteLine("Введите строку, состоящую из русских слов (заглавными буквами):");
        string input = Console.ReadLine();

        // Разделение строки на слова
        string[] words = input.Split(new char[] { ' ', 't' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;

        // Перебор слов и проверка условия
        foreach (string word in words)
        {
            if (word.Length > 0 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        // Вывод результата
        Console.WriteLine($"Количество слов, которые начинаются и заканчиваются одной и той же буквой: {count}");
    }
}
