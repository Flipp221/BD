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
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        private Kreslo _currentKreslo = new Kreslo();
        public Window12()
        {
            InitializeComponent();
            DataContext = _currentKreslo;
            ColorKresloCB.ItemsSource = hhsEntities.GetContext().Color.ToList();
            ProizvodKresloCB.ItemsSource = hhsEntities.GetContext().proizvoditel.ToList();
            TypeKreslaCB.ItemsSource = hhsEntities.GetContext().kreslo_type.ToList();
            GaranKresCB.ItemsSource = hhsEntities.GetContext().Garantiya.ToList();
        }

        private void BtnSohr_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameKresloTB.Text))
                errors.AppendLine("укажите название кресла");
            if (_currentKreslo.Color == null)
                errors.AppendLine("Укажите цвет кресла");
            if (_currentKreslo.proizvoditel == null)
                errors.AppendLine("Укажите производителя");
            if (_currentKreslo.kreslo_type == null)
                errors.AppendLine("Укажите тип кресла");
            if (_currentKreslo.Garantiya == null)
                errors.AppendLine("Укажите гарантию");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentKreslo.id_kresla == 0)
            {
                hhsEntities.GetContext().Kreslo.Add(_currentKreslo);
            }
            try
            {
                hhsEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Window5 wd = new Window5();
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
