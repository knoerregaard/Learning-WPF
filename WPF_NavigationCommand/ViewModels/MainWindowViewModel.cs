using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_NavigationCommand.ViewModels.Commands;
using WPF_NavigationCommand.Views.Pages;

namespace WPF_NavigationCommand.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public string Title { get { return "Applikation X"; } }

        public Page PageContent { get; set; }

        private ICommand setPageContentCommand { get; set; }
        public ICommand SetPageContentCommand { get { return setPageContentCommand; } }

        public MainWindowViewModel()
        {
            Page home = new Home();
            PageContent = home;

            //Sætte SetPageContentCommand 
            setPageContentCommand = new SetPageContentCommand(this);
        }

        

        //The command should execute/invoke the SwapPageContent by setting the PageContent to another object.
        public void SwapPageContent(string name)
        {
            //Pass a new ViewModel to the Page?
            switch (name)
            {
                case "Home":
                    PageContent = new Home();
                    break;
                case "About":
                    PageContent = new About();
                    break;
                default:
                    PageContent = new Home();
                    break;
            }
            OnPropertyChanged("PageContent");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string x)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(x));
        }
    }
}
