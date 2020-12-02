using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Styling.ViewModels.Commands
{
    public class NavCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _execute;
        public NavCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
            //throw new NotImplementedException();
        }
    }
}
