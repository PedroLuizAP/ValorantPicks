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
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private MainViewModel ViewModel;
        public MainView()
        {
            ViewModel = new MainViewModel();
            DataContext = ViewModel;
            InitializeComponent();
            ComboMapas.ItemsSource = Enum.GetValues(typeof(Mapas)).Cast<Mapas>();
        }

        private void Pesquisar_OnClick(object sender, RoutedEventArgs e)
        {
            if (ComboMapas.SelectedItem == null)
            {
                MessageBox.Show("NÃO HÁ DADOS");
                return;
            }

            ViewModel.SelecionaMapa((Mapas)ComboMapas.SelectedItem);         
        }
    }
}
