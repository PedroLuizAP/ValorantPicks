using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ValorantPicks.Model.Enum;
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
        internal async Task Pesquisa()
        {
            switch (SelectedPesquisa)
            {
                case TipoPesquisa.Agente:
                    await SelecionaAgentes();
                    break;

                case TipoPesquisa.Mapa:
                    await SelecionaMapa();
                    break;
            }
        }

        internal async Task SelecionaAgentes()
        {
            if (SelectedAgente == null)
            {
                Informacoes = "DADOS NÃO ENCONTRADOS.";
                return;
            }

            var agente = await agenteService.FindAgenteById(1); //simular id

            Informacoes = $"{agente.Nome} É DO TIPO {agente.Classe.GetClasse()} E POSSUI AS SEGUINTES HABILIDADES{Environment.NewLine}";
            agente.Habilidades.ForEach(habilidade => Informacoes += $"Habilidades :{habilidade.Tipo} - {habilidade.Descricao}");

        }
        internal async Task SelecionaMapa()
        {
            if (SelectedMapa == null)
                return;

            var agentes = await agenteService.FindAgenteByMapa((long)SelectedMapa);

            if (agentes == null || agentes?.Count == 0)
                return;

            Informacoes = $"MAPA SELECIONADO: {SelectedMapa?.GetDescription()}{Environment.NewLine}";

            agentes?.ForEach(agente =>
            {
                Informacoes += $"Mapa bom para {agente.Classe.ToString().ToUpper()}: {agente.Nome} ";
            });
        }
    }
}
