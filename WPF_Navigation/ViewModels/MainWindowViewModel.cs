using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_Navigation.ViewModels.Commands;
using WPF_Navigation.Views.Pages;

namespace WPF_Navigation.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public string SampleText { get { return "Hello"; } }
        public Page PageContent { get; set; }
        public string Title { get { return "Title of the page"; } }

        private ICommand pageNavigationCommand;
        
        public ICommand PageContentCommand
        {
            get
            {
                return pageNavigationCommand;
            }
            //set
            //{
            //    pageNavigationCommand = value;
            //}
        }

        public MainWindowViewModel()
        {
            // The PageContent property will be initialized in the constructor
            PageContent = new Home(new HomeViewModel());

            //On construction the Command pageNavigationCommand will be instantiated.
            //Every command must be instantiated before consumed.
            pageNavigationCommand = new PageNavigationCommand(this);
        }

        //The command should execute/invoke the SwapPageContent by setting the PageContent to another object.
        public void SwapPageContent(string name)
        {
            //Pass a new ViewModel to the Page?
            switch (name)
            {
                case "Home":
                    PageContent = new Home(new HomeViewModel());
                    break;
                case "About":
                    PageContent = new About();
                    break;
                default:
                    PageContent = new Home(new HomeViewModel());
                    break;
            }

            OnPropertyChanged(nameof(PageContent));
        }


        //INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged(string x)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(x));
        }
    }
}
