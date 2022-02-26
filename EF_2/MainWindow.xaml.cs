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

namespace EF_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginPass loginPass;
        public MainWindow()
        {
            InitializeComponent();
            loginPass = new LoginPass();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users id = (from user in loginPass.UsersTable
                        where user.Login == loginTB.Text).FirstOrDefault();
            /*Users admin = new Users() { Login = "admin", Pass = "admin" };
            loginPass.UsersTable.Add(admin);
            loginPass.SaveChanges();*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var users = loginPass.UsersTable;
            foreach(Users user in users) 
            {
                MessageBox.Show(user.Id.ToString() + " " + user.Login + " " + user.Pass);
            }
        }
    }
}
