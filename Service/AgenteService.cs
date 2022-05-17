using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantPicks.Model;
using ValorantPicks.Repository;

namespace ValorantPicks.Service
{
    public class AgenteService
    {
        private AgenteRepository repository;
        internal async Task<Agente> FindAgenteById(long Id)
        {
            return await Task.Run(() => repository.FindById(Id));
        }
    }
}
