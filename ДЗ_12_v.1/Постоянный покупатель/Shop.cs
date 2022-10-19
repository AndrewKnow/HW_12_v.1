using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Program1
{
    public class Shop
    {
        public ObservableCollection<Item> item = new();
        public void Add(int id)
        {
            item.Add(new Item { Id = id, Name = $"Товар {DateTime.Now}" }); // "Товар {DateTime.Now}"
        }
        public void Remove(int id)
        {
            if (item.Count - 1 >= id)
            {
                item.RemoveAt(id);
            }
            else 
            {
                Console.WriteLine($"{id} отсуствует");
            }
        }

    }
}
