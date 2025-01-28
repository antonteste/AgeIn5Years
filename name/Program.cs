using System;
using System.Text;

namespace AgeIn5Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.Write("Введите ваше имя: "); // Запрашиваем у пользователя имя
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст: "); // Запрашиваем у пользователя возраст
            int age = int.Parse(Console.ReadLine());

            int AgeIn5Years = age + 5; // Вычесление возраста через 5 лет

            Console.WriteLine($"Привет, {name}! Через 5 лет Вам будет {AgeIn5Years} лет."); // Выводимый результат
        }
    }
}