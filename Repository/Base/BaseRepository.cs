using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantPicks.Repository.Base
{
    public class BaseRepository
    {
        protected SqlConnection conn;

        public BaseRepository()
        {
            conn = new(@"Data Source=;Initial Catalog=;User ID=;Password=");
        }
    }
}
