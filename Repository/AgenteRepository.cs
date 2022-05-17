﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantPicks.Model;
using ValorantPicks.Model.Enum;

namespace ValorantPicks.Repository
{
    internal class AgenteRepository
    {
        internal AgenteRepository()
        {
        }

        internal Agente FindById(long Id)
        {
#if DEBUG
           Habilidade habilidade = new() { Id = Id, Descricao = "Teste descrição", Tipo = Habilidades.Passiva }; 
#endif

            Agente agente = new() 
            {
#if DEBUG
               Id = Id,
               Nome = "Viper",
               Classe = ClasseAgente.Controlador,
               Habilidades = new () { habilidade}                              
#endif
            };
            return agente;
        }
    }
}