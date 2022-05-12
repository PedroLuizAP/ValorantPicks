using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using ValorantPicks.Helper.Attributes;

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
            return ((Classe)atributo.ElementAt(0)).Description;
        }     
    }
}
