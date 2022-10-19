using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Program1
{
    class Program 
    {
        public static int Num {get; set;}
        static void Main()
        {
            Commands();
        }

        static void Commands()
        {
            Shop shop = new();
            Customer customer = new();

            shop.item.CollectionChanged += customer.OnItemChanged;

            Console.WriteLine("A - ввод товара, D - удаление товара по индексу, X -выход");
            
            bool intBool;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.A)
                {
                    Num++;
                    shop.Add(Num);
                }

                if (key.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Какой товар должен быть удалён? Введите число и нажмите Enter");
                    var removeId = Console.ReadLine();
                    intBool = int.TryParse(removeId, out _);

                    if (intBool)
                    {
                        shop.Remove(int.Parse(removeId));
                    }
                }

                if (key.Key == ConsoleKey.X)
                {
                    break;
                }
            }
        }
    }
}
