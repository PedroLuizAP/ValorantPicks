using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantPicks.Repository.Base
{
    public class BaseRepository
    {
        protected MySqlConnection conn;

        public BaseRepository()
        {
            conn = new("");
        }
    }
}
