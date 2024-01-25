using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__9
{
    class NewObservableCollection<T> : ObservableCollection<T>
    {
        public delegate void DelegateCollectionChange(string? message);

        public event DelegateCollectionChange? CollectionChange;

        public void Print(ObservableCollection<Game> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
                CollectionChange?.Invoke("Выведенны все элементы коллекции");
            }
        }
    }
}
