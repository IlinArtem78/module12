﻿
using System.Runtime.Serialization.Formatters;
class Program
{
    public static void Main(string[] args)
    {
        int k = 0;

        List<User> users = new List<User>(5);
        while (k < users.Count)
        {
            User user = new User();
            Console.WriteLine("Введите имя:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите логин:");
            user.Login = Console.ReadLine();
            Console.WriteLine("Введите премиум подписку:");
            user.IsPremium = bool.Parse(Console.ReadLine()); ;
            Console.WriteLine($"Премиум подписа: {user.IsPremium}");
            k++;
            users.Add(user);
            if (!user.IsPremium)
            {
                ShowAds();
            }
        }

        foreach (var user in users)
        {
            Console.WriteLine(user.Login, user.Name, user.IsPremium);
        }


        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

    }
}

class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }

