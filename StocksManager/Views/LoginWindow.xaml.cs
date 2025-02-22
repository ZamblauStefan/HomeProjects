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

namespace StocksManager.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public string username, password;

        //get the username and password needed to access the data base
        private void username_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            //username = username_box.Text;
            throw new NotImplementedException();
        }

        private void password_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            //password = password_box.Text;
            throw new NotImplementedException();
        }

        private void Log_in_button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Register_button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickCancel(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        public void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ForgotPassword_LeftMouseDown(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reset Password", "Configuration", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

    }
}