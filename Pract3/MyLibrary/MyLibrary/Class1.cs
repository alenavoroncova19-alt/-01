using System;

namespace MyLibrary
{
    public class Tools
    {
        //  2 метода с типом void 
        public void SayHello(string name)
        {
            Console.WriteLine("Привет, " + name + "!");
        }

        public void ShowTime()
        {
            Console.WriteLine("Сейчас: " + DateTime.Now);
        }

        //  3 метода с разными возвращаемыми значениями 
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Average(double a, double b)
        {
            return (a + b) / 2;
        }

        public string ReverseString(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}