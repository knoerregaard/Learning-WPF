using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Button
{
    class ShowTextCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            string text = parameter.ToString();
            if (!String.IsNullOrEmpty(text))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine("123");
            MessageBox.Show(parameter.ToString());
        }
    }
}
