using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using ValorantPicks.Helper.Attributes;
using ValorantPicks.Model;

namespace ValorantPicks.Helper
{
    public static class Functions
    {
        private static object[] FindStringAttribute(Enum eEnum, Type attribute)
        {
            var tipo = eEnum.GetType();
            var membro = tipo.GetMember(eEnum.ToString());
            return membro[0].GetCustomAttributes(attribute, false);
        }
        public static string GetDescription(this Enum eEnum)
        {
            var atributo = FindStringAttribute(eEnum, typeof(DescriptionAttribute));
            return ((DescriptionAttribute)atributo.ElementAt(0)).Description;
        }

        public static string GetClasse(this Enum eEnum)
        {
            var atributo = FindStringAttribute(eEnum, typeof(Classe));
            if(atributo == null) return eEnum.ToString();
            return ((DescriptionAttribute)atributo.ElementAt(0)).Description;
        }

        public static List<Agente> MapAgentes(this DataTable dt)
        {
            List<Agente> listaAgente = new ();
            foreach(DataRow row in dt.Rows)
            {
                listaAgente.Add(row.MapAgente());
            }
            return listaAgente;
        }

        public static Agente MapAgente (this DataRow dt )
        {           
            Agente agente = new()
            {

            };

            return agente;
        }
        public static Agente MapAgente (this SqlDataReader reader )
        {
            Agente agente = new()
            {
               Id = (long)reader["IDAgente"],
               Nome = reader["Nome"].ToString(),
            };

            return agente;
        }
    }
}
