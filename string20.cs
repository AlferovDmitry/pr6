using System;

class Program
{
    static void Main()
    {
        // Ввод числа N
        Console.WriteLine("Введите целое число N (1 ≤ N ≤ 26):");
        int N = int.Parse(Console.ReadLine());

        // Проверка на корректность ввода
        if (N < 1 || N > 26)
        {
            Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 26.");
            return;
        }

        // Вывод N последних букв в обратном порядке
        for (int i = 0; i < N; i++)
        {
            char letter = (char)('z' - i); // 'z' - i для получения обратного порядка
            Console.Write(letter);
        }

        Console.WriteLine(); // Переход на новую строку
    }
}
