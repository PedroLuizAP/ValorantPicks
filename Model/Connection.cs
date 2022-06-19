using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantPicks.Model
{
    public static class Connection
    {
        public static string Instancia { get; set; }
        public static string Banco { get; set; }
        public static string Usuario { get; set; }
        public static string Senha { get; set; }

        public static bool ValidaConnection()
        {
            return !string.IsNullOrEmpty(Instancia) && !string.IsNullOrEmpty(Banco) 
                && !string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Senha); 
        }
    }
}
