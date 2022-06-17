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
using ValorantPicks.ViewModel;

namespace ValorantPicks.View
{
    /// <summary>
    /// Lógica interna para ValorantView.xaml
    /// </summary>
    public partial class ValorantView : Window
    {
        private MainViewModel ViewModel;

        public ValorantView()
        {
            ViewModel = new ();
            DataContext = ViewModel;
            InitializeComponent();
            CloseButton.MouseEnter += TopControls_OnMouseEnter;
            CloseButton.MouseLeave += TopControls_OnMouseLeave;
        }

        private async void Pesquisar_OnClick(object sender, RoutedEventArgs e)
        {
            await ViewModel.Pesquisa();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button.Background = new SolidColorBrush(Colors.Gray);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button.Background = new SolidColorBrush(Color.FromRgb(83, 33, 43));
        }

        private bool _buttonClickable;
        public void TopControls_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var grid = (Grid)sender;
            _buttonClickable = true;
            grid.Background = grid.Name == "CloseButton" ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.DimGray);
        }

        public void TopControls_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_buttonClickable)
                GetType().GetMethod(((Grid)sender).Name + "_Click")?.Invoke(this, null);
        }

        public void TopControls_OnMouseEnter(object sender, MouseEventArgs e)
        {
            var grid = (Grid)sender;
            grid.Background = grid.Name == "CloseButton" ? new SolidColorBrush(Colors.Firebrick) : new SolidColorBrush(Colors.Gray);

            HelperColor(grid);
        }

        public void TopControls_OnMouseLeave(object sender, MouseEventArgs e)
        {
            var grid = (Grid)sender;
            _buttonClickable = false;
            grid.Background = new SolidColorBrush(Colors.Transparent);

            HelperColor(grid);
        }

        private void HelperColor(Grid grid)
        {
            if (VisualTreeHelper.GetChild(grid, 0) is Path child)
                child.Stroke = new SolidColorBrush(Colors.White);
        }

        public void CloseButton_Click()
        {
            Close();
        }
    }
}
