using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("Сегодня 2020 год");
            string name = "Таир";
            Console.WriteLine($"Меня зовут {name}");
            Console.WriteLine("Введите хобби:");
            string hobby = Console.ReadLine();
            Console.WriteLine($"Ваше хобби:{hobby}");
            Console.Write("Сколько вам лет:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш возраст: {age}");

            int a, b;
            Console.Write("Введите первую цифру:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую цифру:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма: {a + b}   {a - b}   {a * b}  {a / b}");
            Console.ReadKey();
        }
    }
}
