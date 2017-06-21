using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    public class Coalition
    {
        public string Name { get; private set; }
        public Politician Premier { get; private set; }
        public List<ElectionResult> Parties = new List<ElectionResult>();

        public Coalition()
        {

        }

        public Coalition(string name, List<ElectionResult> parties)
        {
            Name = name;
            Parties = parties;
            ElectionResult biggest = null;
            foreach (ElectionResult party in parties)
            {
                if (biggest == null || party.Votes > biggest.Votes)
                {
                    biggest = party;
                }
            }
            Premier = biggest.Party.LeadCandidate;
        }

        public bool Mayority(List<ElectionResult> results, Election election)
        {
            int seats = 0;
            foreach (ElectionResult result in results)
            {
                foreach (ElectionResult party in Parties)
                {
                    if (result.Party == party.Party)
                    {
                        seats = seats + result.Seats;
                    }
                }
            }
            if (seats > (election.Seats / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
