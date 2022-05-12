using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ValorantPicks.Model;
using ValorantPicks.Helper;

namespace ValorantPicks.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel() { }
        
        internal void SelecionaMapa()
        {
            Informacoes = $"MAPA SELECIONADO: {SelectedMapa?.GetDescription()}{Environment.NewLine}";
            switch (SelectedMapa)
            {
                case Mapas.Haven:
                    Informacoes += "Mapa bom para Chamber";
                    break;

                case Mapas.Icebox:
                    Informacoes += "Mapa bom para Viper";
                    break;

                case Mapas.Breeze:
                    Informacoes += "Mapa bom para Jett";
                    break;

                case Mapas.Ascent:
                    Informacoes += "Mapa bom para Sova";
                    break;

                case Mapas.Split:
                    Informacoes += "Mapa bom para Reyna";
                    break;

                case Mapas.Bind:
                    Informacoes += "Mapa bom para Brimstone";
                    break;

                case Mapas.Fracture:
                    Informacoes += "Mapa bom para Neon";
                    break;

                default:
                    Informacoes += "DADOS NÃO ENCONTRADO";
                    break;
            }
        }

        private Mapas? _selectedMapa { get; set; }
        public Mapas? SelectedMapa
        {
            get => _selectedMapa;
            set
            {
                _selectedMapa = value;
                OnPropertyChanged();
            }
        } 
        private string _informacoes { get; set; }
        public string Informacoes
        {
            get => _informacoes;
            set
            {
                _informacoes = value;
                OnPropertyChanged();
            }
        }
    }
}
