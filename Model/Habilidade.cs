using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantPicks.Model.Enum;

namespace ValorantPicks.Model
{
    public class Habilidade
    {
        public long Id { get; set; }
        public Habilidades Tipo { get; set; }
        public string Descricao { get; set; }
    }
}
