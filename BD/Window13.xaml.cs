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
    /// Логика взаимодействия для Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        private Microfon _currentMicro = new Microfon();
        public Window13()
        {
            InitializeComponent();
            DataContext = _currentMicro;
            ProizMicCB.ItemsSource = hhsEntities.GetContext().proizvoditel.ToList();
            TypeMicCB.ItemsSource = hhsEntities.GetContext().microfon_type.ToList();
            GaranCB.ItemsSource = hhsEntities.GetContext().Garantiya.ToList();
        }

        private void BtnSohr_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameMicroTB.Text))
                errors.AppendLine("укажите название микрофона");
            if (string.IsNullOrWhiteSpace(MinChaTB.Text))
                errors.AppendLine("укажите минимальную частоту");
            if (string.IsNullOrWhiteSpace(MaxChaTB.Text))
                errors.AppendLine("укажите максимальную частоту");
            if (_currentMicro.proizvoditel == null)
                errors.AppendLine("Укажите производителя");
            if (_currentMicro.microfon_type == null)
                errors.AppendLine("Укажите тип микрофона");
            if (_currentMicro.Garantiya == null)
                errors.AppendLine("Укажите гарантию");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentMicro.id_microfona == 0)
            {
                hhsEntities.GetContext().Microfon.Add(_currentMicro);
            }
            try
            {
                hhsEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Window6 wd = new Window6();
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
