using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantPicks.Helper.Attributes;

namespace ValorantPicks.Model
{
    public enum Agentes
    {
        [Classe("Controlador")]
        Astra,

        [Classe("Controlador")]
        Brimstone,

        [Classe("Controlador")]
        Omen,

        [Classe("Controlador")]
        Viper,

        [Classe("Duelista")]
        Phoenix,

        [Classe("Sentinela")]
        Sage,

        [Classe("Iniciador")]
        Sova,       

        [Classe("Sentinela")]
        Cypher,

        [Classe("Duelista")]
        Reyna,

        [Classe("Sentinela")]
        Killjoy,

        [Classe("Iniciador")]
        Breach,

        [Classe("Duelista")]
        Jett,

        [Classe("Duelista")]
        Raze,

        [Classe("Iniciador")]
        Skye,

        [Classe("Duelista")]
        Yoru,       

        [Classe("Iniciador")]
        Kayo,

        [Classe("Sentinela")]
        Chamber,

        [Classe("Duelista")]
        Neon,
    }
}
