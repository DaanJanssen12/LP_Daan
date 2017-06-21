using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hulptool_Politiek.DAL;

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

        public Election()
        {
        }

        public void ChangeResults(string partyAbbreviation, int votes, ISql sql)
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
                result.Percentage = ((double)result.Votes / (double)totalVotes);
                result.Percentage = Math.Round(result.Percentage, 4, MidpointRounding.AwayFromZero);
                result.Percentage = result.Percentage * 100;
                result.Seats = (Int32)(Math.Round((((double)result.Votes / (double)totalVotes) * Seats), 0, MidpointRounding.AwayFromZero));                
                sql.UpdateResult(result);
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
