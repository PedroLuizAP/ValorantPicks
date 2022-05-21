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
#if DEBUG
            Habilidade habilidade = new() { Id = Id, Descricao = "Teste descrição", Tipo = Habilidades.Passiva };
            agente = new() 
            {
               Id = Id,
               Nome = "Viper",
               Classe = ClasseAgente.Controlador,
               Habilidades = new () { habilidade}                              

            };
#endif

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
                        agente = reader.GetSchemaTable().MapAgente();
                    break;
                }
            }
#endif
                return agente;
        }
    }
}
