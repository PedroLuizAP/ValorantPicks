using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantPicks.Helper;
using ValorantPicks.Model;
using ValorantPicks.Model.Enum;
using ValorantPicks.Repository.Base;

namespace ValorantPicks.Repository
{
    public class AgenteRepository : BaseRepository
    {
        internal AgenteRepository()
        {

        }

        internal Agente FindById(long id)
        {
            Agente agente;
#if DB
            agente = new();
            using (conn)
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = $"SELECT * FROM agentes WHERE idAgente = {id}";
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader != null)
                        ;// agente = reader.GetSchemaTable().MapAgente();
                    break;
                }
                reader?.Close();
            }
            return agente;

#endif
            return agente = new();
        }
        
        internal List<Agente> FindByMapa(long idMapa)
        {
            List<Agente> agentes;
#if DB
            agentes = new();
            using (conn)
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = $"SELECT * FROM agentes a INNERJOIN MapaAgente ma ON ma.IdAgente = a.Idagente WHERE ma.IdMapa = {idMapa}";
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader == null)
                        break;
                        //agentes.Add(reader.GetSchemaTable().MapAgente());
                }
                reader?.Close();
            }
            return agentes;
#endif
            return agentes = new();
        }
    }
}
