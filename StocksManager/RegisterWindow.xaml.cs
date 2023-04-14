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
using System.Windows.Shapes;

namespace StocksManager
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private string register_username, register_password, register_password_confirm, register_email;

        private void register_email_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            register_email = register_email_box.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void register_confirm_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void register_confirm_password_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            register_password_confirm = register_confirm_password_box.Text;
        }

        private void register_password_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            register_password = register_password_box.Text;
        }

        private void register_username_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            register_username = register_username_box.Text;
        }

    }
}
