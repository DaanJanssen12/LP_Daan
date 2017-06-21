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
        public List<Party> Parties { get; set; }

        public Coalition()
        {
            Parties = new List<Party>();
        }

        public Coalition(string name, List<Party> parties)
        {
            Name = name;
            Parties = parties;
        }

        public bool Mayority(List<ElectionResult> results, Election election)
        {
            int seats = 0;
            foreach (ElectionResult result in results)
            {
                foreach (Party party in Parties)
                {
                    if (result.Party == party)
                    {
                        seats = seats + result.Seats;
                        System.Windows.Forms.MessageBox.Show(seats.ToString());
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
