using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    class Election
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        private List<Party> parties;
        private List<ElectionResult> results;

        public Election(string name, int seats)
        {
            Name = name;
            Seats = seats;
        }

        public void AddParty(Party party)
        {
            parties.Add(party);
        }

        public void AddResult(ElectionResult result)
        {
            results.Add(result);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
