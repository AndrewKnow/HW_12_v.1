using System;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Program2
{
    class Program
    {
        static void Main()
        {
            Menu();
            Task.Run(InterestCalculation);
            Commands();
        }

        static void Commands()
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("Введите название книги:");
                    var name = Console.ReadLine();
                    var isAdded = Library.dictionary.TryAdd(name, new Percent());

                    if (isAdded)
                    {
                        Library.dictionary.TryAdd(name, new Percent());
                    }                    
                    Menu();
                }
                if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    // вывод списка книг
                    Console.WriteLine("Список книг:");
                    foreach (var element in Library.dictionary)
                    {
                        Console.WriteLine($"{element.Key} - {element.Value.Counter} %");  
                    }
                    Menu();
                }
                if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {
                    return;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - добавить книгу");
            Console.WriteLine("2 - вывести список непрочитанного");
            Console.WriteLine("3 - выйти");
        }

        static void InterestCalculation ()
        {
            int i = 0;
            while (true)
            {
                i++;
                Thread.Sleep(1000); 

                foreach (var element in Library.dictionary)
                {
                    element.Value.Counter += i;

                    if (element.Value.Counter >= 100)
                    {
                        Library.dictionary.TryRemove(element.Key, out _);
                    }
                }
            }
        }
    }
}
