using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            do
            {
                Console.WriteLine("Выберите программу, которую хотите запустить");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Закрытть програму");
                int user = Convert.ToInt32(Console.ReadLine());
                if (user == 1)
                {
                    Game();
                }
                else if (user == 2)
                {
                    Tablitsa();
                }
                else if (user == 3)
                {
                    Delenie();
                }
                else
                {
                    end = false;
                }
            }while(end);
        }
        static void Game()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 69);
            bool end = true;
            Console.WriteLine("Загадайте число от 0 до 69)))))");
            do
            {
                int user = Convert.ToInt32(Console.ReadLine());
                if (user > value)
                {
                    Console.WriteLine("Возьмите поменьше");
                }
                else if (user < value)
                {
                    Console.WriteLine("Возьмите побольше");
                }
                else
                {
                    end = false;
                    Console.WriteLine("Вы угадали!!!");
                }
            } while (end);
        }

        static void Tablitsa()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int ia = 1; ia < 10; ia++)
                {
                    int res = i * ia;
                    Console.WriteLine("{2}\t", i, ia, res);
                }
            }
        }

        static void Delenie()
        {
            Console.WriteLine("Введите число, у которого хотите узнать делите(ли/ль)");
            int del = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= del; i++)
            {
                if (del % i == 0)
                {
                    Console.Write("{0}  ", i);
                }
            }
        }
    }
}