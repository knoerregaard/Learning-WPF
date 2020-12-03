using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_NavigationCommand.ViewModels.Commands
{
    class SetPageContentCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MainWindowViewModel vm;

        public SetPageContentCommand(MainWindowViewModel mwvm)
        {
            vm = mwvm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine(parameter.ToString());

            vm.SwapPageContent(parameter.ToString());
        }
    }
}
