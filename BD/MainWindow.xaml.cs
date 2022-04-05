using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using BD;

namespace BD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static hhsEntities db = new hhsEntities();
        
        public static number_user vhodUser;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void LvlOne(object sender, RoutedEventArgs e)
        {
            Auth(Login.Text, Password.Password);
        }
        public bool Auth(string Log, string password)
        {
            if (string.IsNullOrEmpty(Log) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин или пароль");
                return false; 
            }
         
            var AuthUser = db.number_user.FirstOrDefault(w => w.Login == Login.Text && w.Password == Password.Password);
            if (AuthUser == null)
            {
                MessageBox.Show("Пользователь не найден");
                return false;
            }
            else
            {
                switch (AuthUser.User.roll.id_roll)
                {
                    case 1:
                        MessageBox.Show("Админ");
                        break;
                    case 3:
                        MessageBox.Show("Клиент");
                        break;

                }
            }
            return true;
        }

        private void registr(object sender, RoutedEventArgs e)
        {
            Window8 wd = new Window8();
            wd.Show();
            this.Close();
        }

    }
}