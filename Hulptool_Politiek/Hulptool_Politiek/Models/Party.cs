using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    class Party
    {
        public string Name { get; private set; }
        public string Abbreviation { get; private set; }
        public Politician LeadCandidate { get; private set; }
        private List<Politician> Members;

        public Party(string name, string abbreviation, Politician leadCandidate)
        {
            Name = name;
            Abbreviation = abbreviation;
            LeadCandidate = leadCandidate;
        }

        public void AddMember(Politician politician)
        {
            Members.Add(politician);
        }

        public override string ToString()
        {
            return Abbreviation.ToString();
        }
    }
}
