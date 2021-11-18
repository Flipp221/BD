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
            DataContext = _currentKeyboard;
            ColorKlavCB.ItemsSource = hhsEntities.GetContext().Color.ToList();
            ProizvodKlavCB.ItemsSource = hhsEntities.GetContext().proizvoditel.ToList();
            PodKlavCB.ItemsSource = hhsEntities.GetContext().Key_illumination_color.ToList();
            TypeKlavCB.ItemsSource = hhsEntities.GetContext().keyboard_type.ToList();
            GarantiyaKlavCB.ItemsSource = hhsEntities.GetContext().Garantiya.ToList();
        }

        private void BtnSohr_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameKlavTB.Text))
                errors.AppendLine("укажите название");
            if (_currentKeyboard.Color == null)
                errors.AppendLine("Укажите цвет");
            if (_currentKeyboard.proizvoditel == null)
                errors.AppendLine("Укажите производителя");
            if (_currentKeyboard.Key_illumination_color == null)
                errors.AppendLine("Укажите тип подсветки");
            if (_currentKeyboard.keyboard_type == null)
                errors.AppendLine("Укажите тип клавиатуры");
            if (_currentKeyboard.Garantiya == null)
                errors.AppendLine("Укажите гарантию");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if(_currentKeyboard.id_keyboard == 0)
            {
                hhsEntities.GetContext().keyboard.Add(_currentKeyboard);
            }
            try
            {
                hhsEntities.GetContext().SaveChanges();
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
    }
}
