using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantPicks.Model.Enum;

namespace ValorantPicks.Model
{
    public class Agente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public ClasseAgente Classe { get; set; }
        public List<Habilidade> Habilidades { get; set; }

    }
}
