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
            DGridKatalog.ItemsSource = hhEntities.GetContext().Kreslo.ToList();

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window1 mw = new Window1();
            mw.Show();
            this.Close();
        }
    }
}
