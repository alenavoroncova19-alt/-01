using System;
using MyLibrary;  // подключаем нашу библиотеку

namespace GitLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование DLL-библиотеки MyLibrary\n");

            // Создаём объект из библиотеки
            Tools tools = new Tools();

            // Тестируем void-методы
            Console.WriteLine("void-методы");
            tools.SayHello("Алена");
            tools.ShowTime();

            Console.WriteLine();

            // Тестируем методы с возвращаемыми значениями
            Console.WriteLine("Методы с возвращаемыми значениями");

            int sum = tools.Add(10, 5);
            Console.WriteLine("Сумма 10 + 5 = " + sum);

            double avg = tools.Average(10.5, 20.5);
            Console.WriteLine("Среднее (10.5 и 20.5) = " + avg);

            string reversed = tools.ReverseString("Привет");
            Console.WriteLine("Перевёрнутая строка 'Привет' = " + reversed);

            Console.WriteLine("\n=== Все методы работают! ===");
            Console.ReadKey();
        }
    }
}