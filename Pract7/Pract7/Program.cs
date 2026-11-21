using System;

namespace Pract7
{
    class Program
    {
        // Задание 1.1: Метод сортировки массива по возрастанию
        static int[] SortAscending(int[] arr)
        {
            int[] result = (int[])arr.Clone();
            Array.Sort(result);
            return result;
        }

        // Задание 1.2: Метод сортировки массива по убыванию 
        static int[] SortDescending(int[] arr)
        {
            int[] result = (int[])arr.Clone();
            Array.Sort(result);
            Array.Reverse(result);
            return result;
        }

        // Задание 1.3: Метод объединения двух массивов в один 
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, 0, result, 0, arr1.Length);
            Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
            return result;
        }

        //  Задание 2: Абсолютная разность между n и 123 
        static int AbsoluteDifference(int n)
        {
            int difference = Math.Abs(n - 123);
            if (n > 123)
            {
                return 3 * difference;
            }
            return difference;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Практика 7: Дополнительные классы и структуры .NET \n");

            // Задание 1: Тестирование методов работы с массивами 
            Console.WriteLine("Задание 1: Методы работы с массивами\n");

            int[] array1 = { 5, 2, 8, 1, 9, 3 };
            int[] array2 = { 7, 4, 6 };

            Console.WriteLine("Исходный массив 1: [" + string.Join(", ", array1) + "]");
            Console.WriteLine("Исходный массив 2: [" + string.Join(", ", array2) + "]");
            Console.WriteLine();

            // Тест метода сортировки по возрастанию
            int[] ascending = SortAscending(array1);
            Console.WriteLine("Сортировка по возрастанию: [" + string.Join(", ", ascending) + "]");

            // Тест метода сортировки по убыванию
            int[] descending = SortDescending(array1);
            Console.WriteLine("Сортировка по убыванию: [" + string.Join(", ", descending) + "]");

            // Тест метода объединения массивов
            int[] merged = MergeArrays(array1, array2);
            Console.WriteLine("Объединение массивов: [" + string.Join(", ", merged) + "]");

            Console.WriteLine();

            // Задание 2: Тестирование метода абсолютной разности 
            Console.WriteLine(" Задание 2: Абсолютная разность \n");

            int n1 = 100;
            int n2 = 150;
            int n3 = 123;

            Console.WriteLine($"n = {n1}: |{n1} - 123| = {AbsoluteDifference(n1)}");
            Console.WriteLine($"n = {n2}: |{n2} - 123| * 3 = {AbsoluteDifference(n2)} (n > 123, поэтому тройная разность)");
            Console.WriteLine($"n = {n3}: |{n3} - 123| = {AbsoluteDifference(n3)}");

            Console.ReadKey();
        }
    }
}