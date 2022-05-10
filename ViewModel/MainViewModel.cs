using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {

        }

        internal void SelecionaMapa(Mapas mapa)
        {
            string nomeMapa = mapa.ToString();

            switch (nomeMapa)
            {
                case "Haven":
                    MessageBox.Show("Mapa bom para Chamber");
                    break;

                case "Icebox":
                    MessageBox.Show("Mapa bom para viper");
                    break;

                case "Breeze":
                    MessageBox.Show("Mapa bom para Jett");
                    break;

                case "Ascent":
                    MessageBox.Show("Mapa bom para Sova");
                    break;

                case "Split":
                    MessageBox.Show("Mapa bom para Reyna");
                    break;

                case "Bind":
                    MessageBox.Show("Mapa bom para Brimstone");
                    break;

                case "Fracture":
                    MessageBox.Show("Mapa bom para Neon");
                    break;

                default:
                    MessageBox.Show("DADOS NÃO ENCONTRADO");
                    break;
            }
        }
    }
}
