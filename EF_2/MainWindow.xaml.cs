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
                        where user.Login == loginTB.Text && user.Pass == passTB.Text 
                        select user ).FirstOrDefault();
            if (id != null) 
            {
                MessageBox.Show(id.Id.ToString());
            }
            else 
            {
                MessageBox.Show("Данного пользователя не существует");
            }
            /*Users admin = new Users() { Login = "admin", Pass = "admin" };
            loginPass.UsersTable.Add(admin);
            loginPass.SaveChanges();*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (loginTB.Text != "" && passTB.Text != "") 
            {
                int count = (from user in loginPass.UsersTable
                             where user.Login == loginTB.Text 
                             select user).Count();
                if (count == 0) 
                {
                    Users user = new Users() { Login = loginTB.Text, Pass = passTB.Text };
                    loginPass.UsersTable.Add(user);
                    loginPass.SaveChanges();
                    MessageBox.Show("Запись добавлена в БД");
                }
                else 
                {
                    MessageBox.Show("Такой пользователь уже существует");
                }
            }
        }
    }
}
