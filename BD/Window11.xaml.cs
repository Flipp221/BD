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
    /// Логика взаимодействия для Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        private naushniki _currenNau = new naushniki();
        public Window11()
        {
            InitializeComponent();
            DataContext = _currenNau;
            ColorNauCB.ItemsSource = hhsEntities.GetContext().Color.ToList();
            TypeMicCB.ItemsSource = hhsEntities.GetContext().Micro_ushi.ToList();
            ProizNauCB.ItemsSource = hhsEntities.GetContext().proizvoditel.ToList();
            NauTypeCB.ItemsSource = hhsEntities.GetContext().Naushniki_type.ToList();
            GarantiyaNauCB.ItemsSource = hhsEntities.GetContext().Garantiya.ToList();

        }

        private void BtnSohr_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameNauTB.Text))
                errors.AppendLine("укажите название наушников");

            if (string.IsNullOrWhiteSpace(peredachaTB.Text))
                errors.AppendLine("укажите тип передачи сигнала");
            if (_currenNau.Color == null)
                errors.AppendLine("Укажите цвет наушников");
            if (_currenNau.Micro_ushi == null)
                errors.AppendLine("Укажите тип микрофона");
            if (_currenNau.proizvoditel == null)
                errors.AppendLine("Укажите производителя");
            if (_currenNau.Naushniki_type == null)
                errors.AppendLine("Укажите тип наушников");
            if (_currenNau.Garantiya == null)
                errors.AppendLine("Укажите гарантию");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currenNau.id_naushnikov == 0)
            {
                hhsEntities.GetContext().naushniki.Add(_currenNau);
            }
            try
            {
                hhsEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Window4 wd = new Window4();
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

