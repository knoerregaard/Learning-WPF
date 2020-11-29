using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Styling.ViewModels;
using System.Threading.Tasks;


namespace WPF_Styling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel = new MainWindowViewModel();

        public MainWindow()
        {
            

            viewModel.FirstName = "Kevin";

            DataContext = viewModel;
            


            InitializeComponent();
            

            //viewModel.FirstName = "Mark"; //The property wont change before we raise an event.

            //viewModel.OnPropertyChanged(nameof(MainWindowViewModel.FirstName)); //We raise an event with OnPropertyChanged. It takes the name of the calling member.
        }

    }
}
