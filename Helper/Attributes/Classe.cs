using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantPicks.Helper.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class Classe : Attribute
    {
        public string Class { get; set; }

        public Classe(string classe)
        {
            Class = classe;
        }

        public virtual string Description => DescriptionValue;

        protected string DescriptionValue 
        { 
            get => Class;
            set => Class = value;             
        }


    }
}
