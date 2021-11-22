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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            //DGridKatalog.ItemsSource = hhsEntities.GetContext().Kreslo.ToList();
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

        private void BtnDob_Click(object sender, RoutedEventArgs e)
        {
            Window12 wd = new Window12();
            wd.Show();
            this.Close();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            var KresloForRemoving = DGridKatalog.SelectedItems.Cast<Kreslo>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить сдедующие{KresloForRemoving.Count()} элементов?", "Внимение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    hhsEntities.GetContext().Kreslo.RemoveRange(KresloForRemoving);
                    hhsEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridKatalog.ItemsSource = hhsEntities.GetContext().Kreslo.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void kreslo_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                hhsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(k => k.Reload());
                DGridKatalog.ItemsSource = hhsEntities.GetContext().Kreslo.ToList();
            }
        }
    }
}
