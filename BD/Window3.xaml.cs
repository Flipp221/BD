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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            //DGridKatalog.ItemsSource = hhsEntities.GetContext().Mouse.ToList();
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
        private void BtnRed_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDob_Click(object sender, RoutedEventArgs e)
        {
            Window10 mw = new Window10();
            mw.Show();
            this.Close();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            var MousesForRemoving = DGridKatalog.SelectedItems.Cast<Mouse>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить сдедующие{MousesForRemoving.Count()} элементов?", "Внимение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    hhsEntities.GetContext().Mouse.RemoveRange(MousesForRemoving);
                    hhsEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridKatalog.ItemsSource = hhsEntities.GetContext().Mouse.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void Mouse_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                hhsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(a => a.Reload());
                DGridKatalog.ItemsSource = hhsEntities.GetContext().Mouse.ToList();
            }
        }
    }
}
