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
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        private Mouse _currentMouse = new Mouse();
        public Window10()
        {
            InitializeComponent();
            DataContext = _currentMouse;
            PodMouseCB.ItemsSource = hhsEntities.GetContext().Key_illumination_color.ToList();
            ProizMouseCB.ItemsSource = hhsEntities.GetContext().proizvoditel.ToList();
            TypeMouseCB.ItemsSource = hhsEntities.GetContext().Mouse_type.ToList();
            GarantiyaCB.ItemsSource = hhsEntities.GetContext().Garantiya.ToList();
        }

        private void BtnSohr_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameMouseTB.Text))
                errors.AppendLine("укажите название мышки");

            if (string.IsNullOrWhiteSpace(DPITB.Text))
                errors.AppendLine("укажите Дипиай мышки");
            if (_currentMouse.Key_illumination_color == null)
                errors.AppendLine("Укажите тип подсветки");
            if (_currentMouse.proizvoditel == null)
                errors.AppendLine("Укажите производителя");
            if (_currentMouse.Mouse_type == null)
                errors.AppendLine("Укажите тип мышки");
            if (_currentMouse.Garantiya == null)
                errors.AppendLine("Укажите гарантию");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentMouse.id_mouse == 0)
            {
                hhsEntities.GetContext().Mouse.Add(_currentMouse);
            }
            try
            {
                hhsEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Window3 wd = new Window3();
                wd.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
