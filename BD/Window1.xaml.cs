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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void Keyboard_game(object sender, MouseEventArgs e)
        {
            Window2 wd = new Window2();
            wd.Show();
            this.Close();
        }
        private void mouse_game(object sender, MouseEventArgs e)
        {
            Window3 wd = new Window3();
            wd.Show();
            this.Close();
        }
        private void ushi_game(object sender, MouseEventArgs e)
        {
            Window4 wd = new Window4();
            wd.Show();
            this.Close();
        }
        private void Kreslo_game(object sender, MouseEventArgs e)
        {
            Window5 wd = new Window5();
            wd.Show();
            this.Close();
        }
        private void micro_game(object sender, MouseEventArgs e)
        {
            Window6 wd = new Window6();
            wd.Show();
            this.Close();
        }
    }
}
