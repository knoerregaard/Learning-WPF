using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_Styling.ViewModels.Commands;

namespace WPF_Styling.ViewModels
{

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public static RoutedCommand NavigateHelp = new RoutedCommand();
        
        

        private string messageTest;

        public string MessageText {
            get { return "Hello"; }
            set { messageTest = value; }
        }

        public NavCommand NaviCommand { get; set; }
        public MessageCommand DisplayMessageCommand { get; set; }

        public MainWindowViewModel()
        {
            
            
            NaviCommand = new NavCommand(dosomething);
            //The DisplayMessage will be passed as an action
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
            

            this.RunCode = new SimpleCommand(this);

            HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }
        public void dosomething()
        {
            Debug.WriteLine("asdasdasdasd");

        }

        public void DisplayMessage()
        {
            MessageBox.Show(MessageText);
        }

        private ICommand runCode;

        public ICommand RunCode
        {
            get
            {
                return runCode;
            }
            set
            {
                runCode = value;
            }
        }
        //public void RunCode()
        //{
        //    Debug.WriteLine("Teskttkaslkasdlk");
        //}



        private ICommand hiButtonCommand;

        private ICommand toggleExecuteCommand { get; set; }

        private bool canExecute = true;

        public string HiButtonContent
        {
            get
            {
                return "click to hi";
            }
        }
        public string Runx()
        {            
            Debug.WriteLine("Hello");
            return "hello";
        }

        //public bool CanExecute
        //{
        //    get
        //    {
        //        return this.canExecute;
        //    }

        //    set
        //    {
        //        if (this.canExecute == value)
        //        {
        //            return;
        //        }

        //        this.canExecute = value;
        //    }
        //}

        public ICommand ToggleExecuteCommand
        {
            get
            {
                return toggleExecuteCommand;
            }
            set
            {
                toggleExecuteCommand = value;
            }
        }

        public ICommand HiButtonCommand
        {
            get
            {
                return hiButtonCommand;
            }
            set
            {
                hiButtonCommand = value;
            }
        }



        public void ShowMessage(object obj)
        {
            var x = obj.ToString();
        }

        public void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
        }

        public string ButtonContent
        {
            get
            {
                return "Click Me more";
            }
        }


        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));



        public event PropertyChangedEventHandler PropertyChanged;

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
      


    }

    public class RelayCommand : ICommand
    {
        private Action<object> execute;

        private Predicate<object> canExecute;

        private event EventHandler CanExecuteChangedInternal;

        public RelayCommand(Action<object> execute) : this(execute, DefaultCanExecute)
        {
        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            if (canExecute == null)
            {
                throw new ArgumentNullException("canExecute");
            }

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
                this.CanExecuteChangedInternal += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
                this.CanExecuteChangedInternal -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute != null && this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        public void OnCanExecuteChanged()
        {
            EventHandler handler = this.CanExecuteChangedInternal;
            if (handler != null)
            {
                //DispatcherHelper.BeginInvokeOnUIThread(() => handler.Invoke(this, EventArgs.Empty));
                handler.Invoke(this, EventArgs.Empty);
            }
        }

        public void Destroy()
        {
            this.canExecute = _ => false;
            this.execute = _ => { return; };
        }

        private static bool DefaultCanExecute(object parameter)
        {
            return true;
        }
    }

}
