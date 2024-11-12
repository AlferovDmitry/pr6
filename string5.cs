using System;

class Program
{
    static void Main()
    {
        // Ввод целых положительных чисел N1 и N2
        Console.WriteLine("Введите целое положительное число N1 (первые символы строки S1):");
        int N1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите целое положительное число N2 (последние символы строки S2):");
        int N2 = int.Parse(Console.ReadLine());

        // Ввод строк S1 и S2
        Console.WriteLine("Введите строку S1:");
        string S1 = Console.ReadLine();

        Console.WriteLine("Введите строку S2:");
        string S2 = Console.ReadLine();

        // Проверка корректности ввода
        if (N1 < 0 || N2 < 0 || N1 > S1.Length || N2 > S2.Length)
        {
            Console.WriteLine("Ошибка: Проверьте, чтобы N1 и N2 были положительными и не превышали длину соответствующих строк.");
            return;
        }

        // Получение первых N1 символов из S1
        string partFromS1 = S1.Substring(0, N1);

        // Получение последних N2 символов из S2
        string partFromS2 = S2.Substring(S2.Length - N2, N2);

        // Формирование новой строки
        string result = partFromS1 + partFromS2;

        // Вывод результата
        Console.WriteLine("Результирующая строка: " + result);
    }
}
