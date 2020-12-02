using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ItemsControl.Models
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string _FirstName, string _LastName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
        }

        //INotifyCollectionChanged
        public static ObservableCollection<Person> GetPersonList()
        {
            return new ObservableCollection<Person>()
            {
                new Person("Klaus", "Nørregaard"),
                new Person("Bente", "Astrøm")
            };
        }
    }
}
