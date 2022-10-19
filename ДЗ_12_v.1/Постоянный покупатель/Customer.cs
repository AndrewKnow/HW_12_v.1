using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Program1
{
    public class Customer
    {
        public void OnItemChanged (object sender, NotifyCollectionChangedEventArgs e) 
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Item newItem = e.NewItems[0] as Item;
                    Console.WriteLine($"Добавлен новый товар: { newItem.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: 
                    Item oldItem = e.OldItems[0] as Item;
                    Console.WriteLine($"Удалён товар: { oldItem.Name}");
                    break;
            }
        }
    }
}

