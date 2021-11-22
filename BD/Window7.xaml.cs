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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
            //DGridKatalog.ItemsSource = hhsEntities.GetContext().User.ToList();
            Visible();
        }
        public void Visible()
        {
            if (MainWindow.vhodUser.id_user != 7)
            {
                BtnClear.Visibility = Visibility.Hidden;
                BtnDob.Visibility = Visibility.Hidden;
            }
            else
            {
                BtnClear.Visibility = Visibility.Visible;
                BtnDob.Visibility = Visibility.Visible;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window1 mw = new Window1();
            mw.Show();
            this.Close();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            var usForRemoving = DGridKatalog.SelectedItems.Cast<User>().ToList();

            if (MessageBox.Show($"Вы точно хотите забанить сдедующих{usForRemoving.Count()} пользователей?", "Внимение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    hhsEntities.GetContext().User.RemoveRange(usForRemoving);
                    hhsEntities.GetContext().SaveChanges();
                    MessageBox.Show("Пользователь забанен");

                    DGridKatalog.ItemsSource = hhsEntities.GetContext().User.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void User_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                hhsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(pq => pq.Reload());
                DGridKatalog.ItemsSource = hhsEntities.GetContext().User.ToList();
            }
        }

        private void BtnDob_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
