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
using System.Windows.Shapes;
using WPF_Login.Models;

namespace WPF_Login
{
    /// <summary>
    /// Interaction logic for MessageWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window, IMessageWindow
    {
        public MessageWindow()
        {
            InitializeComponent();
        }

        string IMessageWindow.HeadBarText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMessageWindow.Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IMessageWindow.Close()
        {
            throw new NotImplementedException();
        }

        void IMessageWindow.Show()
        {
            throw new NotImplementedException();
        }
    }
}
