using System;

namespace GitLab
{
    
    class Calculator
    {
      
        public static int Add(int a, int b)
        {
            return a + b;
        }

       
        private static double Dev(double a, double b)
        {
            if (b == 0)         
                return 0;
            return a / b;
        }

        
        public static void ShowDev(double a, double b)
        {
            Console.WriteLine("Частное: " + Dev(a, b));
        }
    }

    
    class User
    {
       
        public string Login { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Balance { get; set; }     
        public bool IsPremium { get; set; }  

        
        public User(string login, string name, int age, string email)
        {
            Login = login;
            Name = name;
            Age = age;
            Email = email;
            Balance = 0;
            IsPremium = false;
        }

        // Метод: пополнить баланс
        public void AddMoney(int amount)
        {
            Balance += amount;
            Console.WriteLine($"Баланс {Login} пополнен на {amount}. Теперь на счету: {Balance}");
        }

        // Метод: показать всю информацию о пользователе
        public void ShowInfo()
        {
            Console.WriteLine("=== Данные пользователя ===");
            Console.WriteLine("Логин:   " + Login);
            Console.WriteLine("Имя:     " + Name);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("Email:   " + Email);
            Console.WriteLine("Баланс:  " + Balance);
            Console.WriteLine("Премиум: " + IsPremium);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Проверяем задание 1 
            Console.WriteLine("Сумма: " + Calculator.Add(10, 5));  
            Calculator.ShowDev(10, 3);                            

            Console.WriteLine();

            // Проверяем задание 2 
            User user1 = new User("alenavoroncova19", "Алена", 18, "alena@mail.ru");
            user1.ShowInfo();
            user1.AddMoney(500);

            Console.ReadKey();
        }
    }
}