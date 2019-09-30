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
using WpfLogin.Controller;

namespace WpfLogin.View
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            UserController CallUser = new UserController();
            EmployeeController CallEmployee = new EmployeeController();

            if (boxUsername.Text.Length == 0 && boxPassword.Password.Length == 0 && boxConfirmPassword.Password.Length ==0)
            {
                UsernameError.Text = "You Must Enter Valid Username!";
                PasswordError.Text = "You Must Enter Valid Password!";
                ConfirmPasswordError.Text = "You Must Enter Valid Confirm Password!";
                boxUsername.Focus();
                boxPassword.Focus();
                boxConfirmPassword.Focus();
            }
            else if (boxUsername.Text.Length == 0 && boxPassword.Password.Length == 0)
            {
                UsernameError.Text = "You Must Enter Valid Username!";
                PasswordError.Text = "You Must Enter Valid Password!";
                boxPassword.Focus();
                boxConfirmPassword.Focus();
            }
            else if (boxUsername.Text.Length == 0 && boxConfirmPassword.Password.Length == 0)
            {
                UsernameError.Text = "You Must Enter Valid Username!";
                ConfirmPasswordError.Text = "You Must Enter Valid Confirm Password!";
                boxUsername.Focus();
                boxConfirmPassword.Focus();
            }
            else if (boxPassword.Password.Length == 0 && boxConfirmPassword.Password.Length == 0)
            {
                
                PasswordError.Text = "You Must Enter Valid Password!";
                ConfirmPasswordError.Text = "You Must Enter Valid Confirm Password!";
                boxPassword.Focus();
                boxConfirmPassword.Focus();
            }
            else if (boxUsername.Text.Length == 0)
            {
                UsernameError.Text = "You Must Enter Valid Username!";
                boxUsername.Focus();
                
            }
            else if (boxPassword.Password.Length == 0 )
            {
                PasswordError.Text = "You Must Enter Valid Password!";
                boxPassword.Focus();
            }
            else if (boxConfirmPassword.Password.Length == 0)
            {
                ConfirmPasswordError.Text = "You Must Enter Valid Confirm Password!";
                boxConfirmPassword.Focus();
            }
            else if (boxConfirmPassword.Password != boxPassword.Password )
            {
                ConfirmPasswordError.Text = "Your Password Need to Enter The Same Password!";
                boxConfirmPassword.Focus();
            }
            else
            {
                string username = boxUsername.Text;
                string password = boxPassword.Password;
                CallUser.AddUser(username, password);
                string firstname = boxFirstname.Text;
                string lastname = boxLastname.Text;
                string address = boxAddress.Text;
                string email = boxEmail.Text;
                CallEmployee.Addemployee(firstname, lastname, address, email);
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();

                

            }


        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
