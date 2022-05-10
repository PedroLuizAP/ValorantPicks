﻿using System;
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
                MessageBox.Show("Mapa bom para Chamber");
            else if (text.Equals("Icebox"))
                MessageBox.Show("Mapa bom para viper");
            else if (text.Equals("Breeze"))
                MessageBox.Show("Mapa bom para Jett");
            else if (text.Equals("Ascent"))
                MessageBox.Show("Mapa bom para Sova");
            else if (text.Equals("Split"))
                MessageBox.Show("Mapa bom para Reyna");
            else if (text.Equals("Bind"))
                MessageBox.Show("Mapa bom para Brimstone");
            else if (text.Equals("Fracture"))
                MessageBox.Show("Mapa bom para Neon");
            else
                MessageBox.Show("DADOS NÃO ENCONTRADO");


        }
    }
}
