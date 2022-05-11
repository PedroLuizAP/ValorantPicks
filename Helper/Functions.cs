using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ValorantPicks.Helper
{
    public static class Functions 
    {
        public static string Description(this Enum eEnum)
        {
            var tipo = eEnum.GetType();
            var membro = tipo.GetMember(eEnum.ToString());
            var atributo = membro[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return ((DescriptionAttribute)atributo.ElementAt(0)).Description;
        }
    }
}
