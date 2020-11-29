using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Styling.ViewModels.Commands
{
    public class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _execute;

        //Action er en delegate. Dette anvendes istedet for en dedikeret ViewModel  der kun tager imod den konkrete ViewModel. 
        public MessageCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //The delegate will be invoked
            _execute.Invoke();
            //throw new NotImplementedException();
        }
    }
}
