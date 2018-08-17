using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderdarkCompanion
{
    public class Character
    {
        private int survivalMod;
        private int perceptionMod;
        private int wisdomMod;
        private int constitutionMod;

        private Dictionary<int, int> roleModLookup;

        public Character(string name, int survivalMod, int perceptionMod, int wisdomMod, int constitutionMod)
        {
            Name = name;
            this.survivalMod = survivalMod;
            this.perceptionMod = perceptionMod;
            this.wisdomMod = wisdomMod;
            this.constitutionMod = constitutionMod;

            roleModLookup = new Dictionary<int, int>
            {
                { 0, survivalMod }, { 1, survivalMod }, { 2, perceptionMod }, { 3, survivalMod }
            };
        }

        public string Name { get; private set; }

        public string GetRollString(int roleIndex)
        {
            return string.Format("1 d 20 + {0}", roleModLookup[roleIndex]);
        }

        public bool SurvivalCheck(int roll, int dc)
        {
            return roll + survivalMod >= dc;
        }

        public bool PerceptionCheck(int roll, int dc)
        {
            return roll + perceptionMod >= dc;
        }

        public int ForageRoll(int roll)
        {
            return roll + wisdomMod;
        }

        public bool ConstitutionCheck(int roll, int dc)
        {
            return roll + constitutionMod >= dc;
        }
    }
}
