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
        public static hhEntities db = new hhEntities();
        
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

        private void LvlOne(object sender, RoutedEventArgs e)
        {
            foreach(var number_User in MainWindow.db.number_user)
            {
                if(number_User.Login == Login.Text.Trim())
                {
                    if(number_User.Password == Password.Password.Trim() && number_User.id_user != 7)
                        {
                            MessageBox.Show($"Привет Пользователь  ваш персональный Id - {number_User.id_user}");
                            MainWindow.vhodUser = number_User;
                        
                    }
                    if(number_User.Password == Password.Password.Trim() && number_User.id_user == 7)
                        {
                            MessageBox.Show($"Привет админ  ваш персональный Id -  {number_User.id_user}");
                        MainWindow.vhodUser = number_User;

                    }
                        Window1 wd = new Window1();
                        wd.Show();
                        this.Close();

                }
            }
        }

        private void registr(object sender, RoutedEventArgs e)
        {
            Window8 wd = new Window8();
            wd.Show();
            this.Close();
        }

    }
}