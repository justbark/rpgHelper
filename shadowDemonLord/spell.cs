using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowDemonLord
{
    [Serializable]
    public class spell
    {
        private int spellNumber;
        private string spellName;
        private string castsPerDay;
        private string casts;
        private string rank;
        private string statVStat;
        private string description;

        public int SpellNumber
        {
            get { return spellNumber; }
            set { spellNumber = value; }
        }
        public string SpellName
        {
            get { return spellName; }
            set { spellName = value; }
        }
        public string CastsPerDay
        {
            get { return castsPerDay; }
            set { castsPerDay = value; }
        }
        public string Casts
        {
            get { return casts; }
            set { casts = value; }
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public string StatVStat
        {
            get { return statVStat; }
            set { statVStat = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
