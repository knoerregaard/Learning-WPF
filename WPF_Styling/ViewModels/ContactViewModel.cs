using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Styling.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public string name { get { return "Name of someone"; }  }

        public int phone { get { return 22334455; }  }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
