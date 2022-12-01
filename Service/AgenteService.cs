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
        private AgenteRepository repository = new();
        internal async Task<Agente> FindAgenteById(long id)=>return await Task.Run(() => repository.FindById(id));
        
        
        internal async Task<List<Agente>> FindAgenteByMapa(long idMapa)
        {
            return await Task.Run(() => repository.FindByMapa(idMapa));
        }
    }
}
