using System;
using MyLibrary;

namespace Способ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("СПОСОБ 1: Ссылка на проект\n");

            Tools t = new Tools();

            Console.WriteLine("void методы");
            t.SayHello("Алена");
            t.ShowTime();

            Console.WriteLine("\n--- методы с возвращаемыми значениями ---");
            Console.WriteLine("Сумма 10+5 = " + t.Add(10, 5));
            Console.WriteLine("Среднее (10.5, 20.5) = " + t.Average(10.5, 20.5));
            Console.WriteLine("Перевёрнуто 'Привет' = " + t.ReverseString("Привет"));

            Console.ReadKey();
        }
    }
}