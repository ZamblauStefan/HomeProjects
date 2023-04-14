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

namespace StocksManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        

        private string username, password;

        //get the username and password needed to access the data base
        private void username_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            username = username_box.Text;
        }

        private void password_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            password = password_box.Text;
        }

        private void Log_in_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void register_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickCancel(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }


    }
}
