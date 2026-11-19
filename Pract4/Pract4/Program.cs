using System;

namespace Pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практика 4: Обработка исключений\n");

            //Пример 1: Деление на ноль
            Console.WriteLine("Пример 1: Деление на ноль");
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b; // Здесь возникнет ошибка!
                Console.WriteLine("Результат: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Метод, где произошла ошибка: " + ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("Блок finally выполнился (ошибка или нет — неважно)");
            }

            Console.WriteLine();

            //Пример 2: Выход за границы массива
            Console.WriteLine("Пример 2: Выход за границы массива");
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("Элемент с индексом 10: " + numbers[10]); // Ошибка!
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Метод: " + ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("Блок finally выполнился");
            }

            Console.WriteLine();

            //Пример 3: Неправильный формат числа
            Console.WriteLine("Пример 3: Неправильный формат числа");
            try
            {
                string text = "abc";
                int number = int.Parse(text); // Ошибка! "abc" нельзя превратить в число
                Console.WriteLine("Число: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Метод: " + ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("Блок finally выполнился");
            }

            Console.WriteLine();

            //Пример 4: Несколько catch сразу
            Console.WriteLine("Пример 4: Несколько catchвтп");
            try
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();
                int value = int.Parse(input);
                int[] arr = { 10, 20, 30 };
                Console.WriteLine("Элемент: " + arr[value]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели не число!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: индекс за пределами массива!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неизвестная ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }

            Console.ReadKey();
        }
    }
}