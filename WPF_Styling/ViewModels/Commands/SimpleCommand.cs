using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Styling.ViewModels.Commands
{
    class SimpleCommand : ICommand
    {
        public MainWindowViewModel ViewModel { get; set; } 

        public SimpleCommand(MainWindowViewModel viewmodel)
        {
            this.ViewModel = viewmodel;
        }

        //Event when fired when true or false
        public event EventHandler CanExecuteChanged;

        //Can or cannot execute?
        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        //Executes the command when called
        public void Execute(object parameter)
        {
            ViewModel.Runx();
            //throw new NotImplementedException();
        }
    }
}
