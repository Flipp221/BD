using DocumentFormat.OpenXml.ExtendedProperties;
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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        private keyboard _currentKeyboard = new keyboard();
        public Window9()
        {
            InitializeComponent();
            ColorKlavCB.ItemsSource = hhEntities.GetContext().Color.ToList();
            ProizvodKlavCB.ItemsSource = hhEntities.GetContext().proizvoditel.ToList();
            PodKlavCB.ItemsSource = hhEntities.GetContext().Key_illumination_color.ToList();
            TypeKlavCB.ItemsSource = hhEntities.GetContext().keyboard_type.ToList();
            GarantiyaKlavCB.ItemsSource = hhEntities.GetContext().Garantiya.ToList();
            DataContext = _currentKeyboard;
        }

        private void BtnSohr_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameKlavTB.Text))
                errors.AppendLine("укажите название");
            if (ColorKlavCB.SelectedItem == null)
                errors.AppendLine("Укажите цвет");
            

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if(_currentKeyboard.id_keyboard == 0)
            {
                hhEntities.GetContext().keyboard.Add(_currentKeyboard);
            }
            try
            {
                hhEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Window2 wd = new Window2();
                wd.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void NameKlavTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            _currentKeyboard.Name = NameKlavTB.Text;
        }

        private void ColorKlavCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = new ComboBox();
            //_currentKeyboard.Color = MainWindow.db.Color.Find(ColorKlavCB.SelectedIndex);
        }
    }
}
