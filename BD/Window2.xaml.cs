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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        public Window2()
        {
            InitializeComponent();
            //DGridKatalog.ItemsSource = hhEntities.GetContext().keyboard.ToList();
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
            Window9 mw = new Window9();
            mw.Show();
            this.Close();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            var keyboardsForRemoving = DGridKatalog.SelectedItems.Cast<keyboard>().ToList();

            if(MessageBox.Show($"Вы точно хотите удалить сдедующие{keyboardsForRemoving.Count()} элементов?" , "Внимение" , 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    hhEntities.GetContext().keyboard.RemoveRange(keyboardsForRemoving);
                    hhEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridKatalog.ItemsSource = hhEntities.GetContext().keyboard.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                hhEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridKatalog.ItemsSource = hhEntities.GetContext().keyboard.ToList();
            }
        }
    }
}
