using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                SqlCommand command = conn.CreateCommand();
                command.CommandText = $"SELECT IDAgente, Nome FROM agente WHERE IDAgente = {id}";
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() && reader != null)
                    reader.MapAgente();

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

                DataTable dt = new();
                conn.Open();
                string query = $"SELECT * FROM agentes WHERE idAgente = {idMapa}";
                SqlDataAdapter value = new(query, conn);
                value.Fill(dt);
                agentes = dt.MapAgentes();
                conn?.Close();
            }
            return agentes;
#endif
        }
    }
}
