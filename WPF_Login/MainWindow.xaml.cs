﻿using System;
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
using WPF_Login.Pages;

namespace WPF_Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PageFrame.Content = new LoginPage();
        }

        private void ButtonClick_SayHello(object sender, RoutedEventArgs e)
        {
            string TxtSayWhat = TxtBox_SayWhat.Text;
            MessageBox.Show(TxtSayWhat);

        }
    }
}
