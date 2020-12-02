using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_Event
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //In the constructor wire up the EventHandler with a method.
            RaisedPersonApprovedEvent += MainWindow_RaisedPersonApprovedEvent;
        }
        // If triggered, a person is registered approved. A string is passed to the listeners
        public event EventHandler<string> RaisedPersonApprovedEvent;


        private void MainWindow_RaisedPersonApprovedEvent(object sender, string e)
        {
            // What to do
            //The EventHandler emits a string.
            Debug.WriteLine(e);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Invoke the event with this and a string
            RaisedPersonApprovedEvent?.Invoke(this, "... a text  ...");
        }
    }
}
