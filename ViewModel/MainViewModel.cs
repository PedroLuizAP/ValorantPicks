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

        private Agentes? _selectedAgente { get; set; }
        public Agentes? SelectedAgente
        {
            get => _selectedAgente;
            set
            {
                _selectedAgente = value;
                OnPropertyChanged();
            }
        }

        private TipoPesquisa _selectedPesquisa { get; set; } = TipoPesquisa.Mapa;
        public TipoPesquisa SelectedPesquisa
        {
            get => _selectedPesquisa;
            set
            {
                LegendaBusca = value == TipoPesquisa.Agente ? "Agentes:" : "Mapas:";
                VisibilityAgentes = value == TipoPesquisa.Agente ? Visibility.Visible : Visibility.Collapsed;
                VisibilityMapas = value == TipoPesquisa.Mapa ? Visibility.Visible : Visibility.Collapsed; ;
                _selectedPesquisa = value;
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

        private string _legendaBusca { get; set; } = "Mapas:";

        public string LegendaBusca
        {
            get => _legendaBusca;
            set
            {
                _legendaBusca = value;
                OnPropertyChanged();
            }
        }

        private Visibility _visibilityMapas { get; set; }
        public Visibility VisibilityMapas
        {
            get => _visibilityMapas;
            set
            {
                _visibilityMapas = value;
                OnPropertyChanged();
            }
        }

        private Visibility _visibilityAgentes { get; set; }
        public Visibility VisibilityAgentes
        {
            get => _visibilityAgentes;
            set
            {
                _visibilityAgentes = value;
                OnPropertyChanged();
            }
        }

        internal void SelecionaAgentes()
        {
            if (SelectedAgente == null)
            {
                Informacoes = "DADOS NÃO ENCONTRADOS.";
                return;
            }
            Informacoes = $"INFORMAÇÕES DO AGENTE SELECIONADO: {Environment.NewLine}";

            Informacoes += $"{SelectedAgente} é um {SelectedAgente.GetClasse()}";            
        }
        internal void SelecionaMapa()
        {
            Informacoes = $"MAPA SELECIONADO: {SelectedMapa?.GetDescription()}{Environment.NewLine}";
            switch (SelectedMapa)
            {
                case Mapas.Haven:
                    Informacoes += $"Mapa bom para {Agentes.Chamber.GetClasse()}: {Agentes.Chamber}";
                    break;

                case Mapas.Icebox:
                    Informacoes += $"Mapa bom para {Agentes.Viper.GetClasse()}: {Agentes.Viper}";
                    break;

                case Mapas.Breeze:
                    Informacoes += $"Mapa bom para {Agentes.Jett.GetClasse()}: {Agentes.Jett}";
                    break;

                case Mapas.Ascent:
                    Informacoes += $"Mapa bom para {Agentes.Sova.GetClasse()}: {Agentes.Sova}";
                    break;

                case Mapas.Split:
                    Informacoes += $"Mapa bom para {Agentes.Reyna.GetClasse()}: {Agentes.Reyna}";
                    break;

                case Mapas.Bind:
                    Informacoes += $"Mapa bom para {Agentes.Brimstone.GetClasse()}: {Agentes.Brimstone}";
                    break;

                case Mapas.Fracture:
                    Informacoes += $"Mapa bom para {Agentes.Neon.GetClasse()}: {Agentes.Neon}";
                    break;

                default:
                    Informacoes += "DADOS NÃO ENCONTRADO";
                    break;
            }
        }
    }
}
