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
using WpfLogin.Controller;
using WpfLogin.View;

namespace WpfLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Username_txt.Text = Properties.Settings.Default.Username;
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            UserController CallUser = new UserController();

            if(Username_txt.Text.Length == 0 && Password_pass.Password.Length == 0)
            {
                UsernameError.Text = "Username Not Valid !";
                PasswordError.Text = "Wrong Password Please Try Again";
                Password_pass.Focus();
                Username_txt.Focus();
            }
            else if (Username_txt.Text.Length == 0)
            {
                UsernameError.Text = "Username Not Valid";
                Username_txt.Focus();
            }
            else if (Password_pass.Password.Length == 0)
            {
                PasswordError.Text = "Wrong Password Please Try Again";
                Password_pass.Focus();
            } else
            {
                string username = Username_txt.Text;
                string password = Password_pass.Password;

                CallUser.UserLogin(username, password);
                this.Hide();
                Home home = new Home(username);
                home.Show();
               
            }


        }

        private void Register(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show(); 
        }


        private void RememberCheck_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Username = Username_txt.Text;
            Properties.Settings.Default.Save();
        }
    }
}
