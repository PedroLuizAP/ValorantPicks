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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboMapas.ItemsSource = Enum.GetValues(typeof(Mapas)).Cast<Mapas>();
        }

        private void Botao_OnClick(object sender, RoutedEventArgs e)
        {
            if (ComboMapas.SelectedItem == null)
            {
                MessageBox.Show("NÃO HÁ DADOS");
                return;
            }

            string text = ComboMapas.SelectedItem.ToString();
            if (text.Equals("Haven"))
                MessageBox.Show("MAPA BOM PRA JETT");
            else if (text.Equals("Icebox"))
                MessageBox.Show("MAPA BOM PRA VIPER");
            else if (text.Equals("Breeze"))
                MessageBox.Show("MAPA BOM PRA KILL JOY");
            else
                MessageBox.Show("DADOS NÃO ENCONTRADO");


        }
    }
}
