using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    public class Coalition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Politician Premier { get; set; }
        public string ElectionName { get; set; }
        public List<ElectionResult> Parties = new List<ElectionResult>();
        public bool Mayority { get; set; }

        public Coalition()
        {

        }

        public Coalition(string name, List<ElectionResult> parties)
        {
            Name = name;
            Parties = parties;
            SelectPremier();
        }

        public void SelectPremier()
        {
            ElectionResult biggest = null;
            foreach (ElectionResult party in Parties)
            {
                if (biggest == null || party.Votes > biggest.Votes)
                {
                    biggest = party;
                }
            }
            Premier = biggest.Party.LeadCandidate;
        }

        public bool aMayority(List<ElectionResult> results, Election election)
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
                Mayority = true;
                return true;
            }
            else
            {
                Mayority = false;
                return false;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
