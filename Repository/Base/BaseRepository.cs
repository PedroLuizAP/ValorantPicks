using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantPicks.Model;

namespace ValorantPicks.Repository.Base
{
    public class BaseRepository
    {
        protected SqlConnection conn;
        public BaseRepository()
        {
            conn = new($"Data Source={Connection.Instancia};Initial Catalog={Connection.Banco};User ID={Connection.Usuario};Password={Connection.Senha}");
        }
    }
}
