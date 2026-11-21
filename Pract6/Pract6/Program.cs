using System;
using System.Globalization;

namespace Pract6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практика 6: Работа с датами и временем\n");

            //Пример 1: Метод Parse()
            Console.WriteLine("Пример 1: Метод Parse()");
            try
            {
                string dateStr1 = "21.11.2026 14:30:00";
                DateTime date1 = DateTime.Parse(dateStr1);
                Console.WriteLine($"Исходная строка: \"{dateStr1}\"");
                Console.WriteLine($"Результат Parse(): {date1}");
                Console.WriteLine($"Год: {date1.Year}, Месяц: {date1.Month}, День: {date1.Day}");
                Console.WriteLine($"Часы: {date1.Hour}, Минуты: {date1.Minute}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка формата: " + ex.Message);
            }

            Console.WriteLine();

            // Пример 2: Метод ParseExact() 
            Console.WriteLine("Пример 2: Метод ParseExact()");
            try
            {
                string dateStr2 = "21/11/2026";
                string format = "dd/MM/yyyy";
                DateTime date2 = DateTime.ParseExact(dateStr2, format, CultureInfo.InvariantCulture);
                Console.WriteLine($"Исходная строка: \"{dateStr2}\"");
                Console.WriteLine($"Формат: \"{format}\"");
                Console.WriteLine($"Результат ParseExact(): {date2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка формата: " + ex.Message);
            }

            Console.WriteLine();

            // Пример 3: Метод TryParse() 
            Console.WriteLine("Пример 3: Метод TryParse()");
            string dateStr3 = "21 ноября 2026";
            DateTime date3;
            bool success3 = DateTime.TryParse(dateStr3, out date3);

            Console.WriteLine($"Исходная строка: \"{dateStr3}\"");
            Console.WriteLine($"Результат TryParse(): {success3}");
            if (success3)
            {
                Console.WriteLine($"Дата: {date3}");
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в дату");
            }

            Console.WriteLine();

            //Пример 4: Метод TryParseExact()
            Console.WriteLine("Пример 4: Метод TryParseExact()");
            string dateStr4 = "21-11-2026";
            string format4 = "dd-MM-yyyy";
            DateTime date4;
            bool success4 = DateTime.TryParseExact(dateStr4, format4, CultureInfo.InvariantCulture, DateTimeStyles.None, out date4);

            Console.WriteLine($"Исходная строка: \"{dateStr4}\"");
            Console.WriteLine($"Формат: \"{format4}\"");
            Console.WriteLine($"Результат TryParseExact(): {success4}");
            if (success4)
            {
                Console.WriteLine($"Дата: {date4}");
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в дату");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}