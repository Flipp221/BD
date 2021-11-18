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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            DGridKatalog.ItemsSource = hhsEntities.GetContext().naushniki.ToList();
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

        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
