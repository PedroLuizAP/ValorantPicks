using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using ValorantPicks.Service;

namespace ValorantPicks.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel() 
        { 
            agenteService = new();
        }

        protected AgenteService agenteService;


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
