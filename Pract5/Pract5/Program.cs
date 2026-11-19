using System;
using System.Text;

namespace Pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практика 5: Работа со строками\n");

            //Пример 1: Сравнение строк через Compare()
            Console.WriteLine("Пример 1: Метод Compare()");
            string str1 = "Hello";
            string str2 = "Hello";
            string str3 = "World";

            int result1 = string.Compare(str1, str2);
            int result2 = string.Compare(str1, str3);

            Console.WriteLine($"Compare(\"{str1}\", \"{str2}\") = {result1} (0 значит равны)");
            Console.WriteLine($"Compare(\"{str1}\", \"{str3}\") = {result2} (отрицательное значит str1 < str3)");

            Console.WriteLine();

            // Пример 2: Сравнение через Equals()
            Console.WriteLine("Пример 2: Метод Equals()");
            bool equal1 = str1.Equals(str2);
            bool equal2 = str1.Equals(str3);

            Console.WriteLine($"\"{str1}\".Equals(\"{str2}\") = {equal1}");
            Console.WriteLine($"\"{str1}\".Equals(\"{str3}\") = {equal2}");

            Console.WriteLine();

            //Пример 3: Сравнение через CompareOrdinal()
            Console.WriteLine("Пример 3: Метод CompareOrdinal()");
            int ordinal1 = string.CompareOrdinal("abc", "ABC");
            int ordinal2 = string.CompareOrdinal("abc", "abc");

            Console.WriteLine($"CompareOrdinal(\"abc\", \"ABC\") = {ordinal1} (сравнивает по кодам символов)");
            Console.WriteLine($"CompareOrdinal(\"abc\", \"abc\") = {ordinal2} (равны)");

            Console.WriteLine();

            //Пример 4: Поиск через IndexOf()
            Console.WriteLine("Пример 4: Метод IndexOf()");
            string text = "Hello, World!";
            int index1 = text.IndexOf("World");
            int index2 = text.IndexOf("xyz");

            Console.WriteLine($"Индекс \"World\" в \"{text}\" = {index1}");
            Console.WriteLine($"Индекс \"xyz\" в \"{text}\" = {index2} (-1 значит не найдено)");

            Console.WriteLine();

            //Пример 5: Проверка через Contains()
            Console.WriteLine("Пример 5: Метод Contains()");
            bool contains1 = text.Contains("World");
            bool contains2 = text.Contains("xyz");

            Console.WriteLine($"\"{text}\".Contains(\"World\") = {contains1}");
            Console.WriteLine($"\"{text}\".Contains(\"xyz\") = {contains2}");

            Console.WriteLine();

            //Пример 6: Операторы == и != 
            Console.WriteLine(" Пример 6: Операторы == и != ");
            string s1 = "Test";
            string s2 = "Test";
            string s3 = "test";

            Console.WriteLine($"\"{s1}\" == \"{s2}\" → {s1 == s2}");
            Console.WriteLine($"\"{s1}\" == \"{s3}\" → {s1 == s3}");
            Console.WriteLine($"\"{s1}\" != \"{s3}\" → {s1 != s3}");

            Console.WriteLine();

            // Пример 7: Другие методы работы со строками
            Console.WriteLine("Пример 7: Другие методы ");
            string example = "  Hello World  ";

            Console.WriteLine($"Исходная строка: \"{example}\"");
            Console.WriteLine($"ToUpper(): \"{example.ToUpper()}\"");
            Console.WriteLine($"ToLower(): \"{example.ToLower()}\"");
            Console.WriteLine($"Trim(): \"{example.Trim()}\"");
            Console.WriteLine($"Replace(\"World\", \"C#\"): \"{example.Replace("World", "C#")}\"");
            Console.WriteLine($"Substring(2, 5): \"{example.Substring(2, 5)}\"");

            Console.WriteLine();

            //Пример 8: StringBuilder
            Console.WriteLine("Пример 8: StringBuilder");
            StringBuilder sb = new StringBuilder();
            sb.Append("Привет");
            sb.Append(", ");
            sb.Append("мир");
            sb.Append("!");

            Console.WriteLine($"StringBuilder результат: \"{sb.ToString()}\"");
            sb.Replace("мир", "C#");
            Console.WriteLine($"После Replace: \"{sb.ToString()}\"");

            Console.ReadKey();
        }
    }
}