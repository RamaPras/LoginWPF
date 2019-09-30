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

namespace WpfLogin.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private string guname;

        public Home(string uname)
        {
            InitializeComponent();
            UnameSetter(uname);
            WelcomeMessage.Text = "Welcome Home, " + uname + "!";
        }

        private void UnameSetter(string uname)
        {
            guname = uname;
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Log out Succes");
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ChangePassword changepword = new ChangePassword();
            changepword.Show();
        }
    }
}
