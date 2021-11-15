using MySql.Data.MySqlClient.Memcached;
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


namespace BD
{
    /// <summary>
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (NicknameTB.Text == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                User user = new User();
                user.name = NicknameTB.Text;
                user.phone = PhoneTB.Text.Length;
                user.adress = AdressTB.Text;
                user.age = AgeTB.Text.Length;
                user.id_roll = 3;

                number_user number_User = new number_user();
                number_User.Login = LoginTB.Text;
                number_User.Password = PassTB.Text;
                number_User.id_user = user.Id_user;
                MainWindow.db.User.Add(user);
                MainWindow.db.number_user.Add(number_User);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Успешно!");
            }
        }

        private void PassTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
