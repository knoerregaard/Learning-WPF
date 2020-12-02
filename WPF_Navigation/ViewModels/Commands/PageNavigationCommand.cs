using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Navigation.ViewModels.Commands
{
    class PageNavigationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MainWindowViewModel vm;

        public PageNavigationCommand(MainWindowViewModel mwvm)
        {
            vm = mwvm;
        }
        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {

            Debug.WriteLine("Hello from command");
            vm.SwapPageContent(parameter.ToString());
        }
    }
}
