using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    public class Election
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Party> parties = new List<Party>();
        public List<ElectionResult> results = new List<ElectionResult>();

        public Election(string name, int seats)
        {
            Name = name;
            Seats = seats;
        }

        public void ChangeResults(string partyAbbreviation, int votes)
        {
            int totalVotes = 0;
            foreach (ElectionResult result in results)
            {
                if (result.Party.Abbreviation == partyAbbreviation)
                {
                    result.Votes = votes;
                }
                totalVotes = totalVotes + result.Votes;
            }

            foreach (ElectionResult result in results)
            {
                result.Percentage = (result.Votes / totalVotes);
                result.Seats = ((result.Votes / totalVotes) * Seats);
                //Sql query
            }

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
