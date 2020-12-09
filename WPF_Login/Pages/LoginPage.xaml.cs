using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPF_Login.Models;

namespace WPF_Login.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        
        private bool isAuthenticatedUIFlag;


        public bool IsAuthenticatedUIFlag
        { 
            get { return isAuthenticatedUIFlag; }
            set
            {
                isAuthenticatedUIFlag = value;                
            }
        }


        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            User user = new User();
            IsAuthenticatedUIFlag = user.Login(TxtBox_UserName.Text, TxtBox_Password.Text);

        }
    }
}
