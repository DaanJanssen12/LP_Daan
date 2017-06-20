using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    class ElectionResult
    {
        public Party Party { get; private set; }
        public int Votes { get; private set; }
        public double Percentage { get; private set; }
        public int Seats { get; private set; }

        public ElectionResult(Party party, int votes, double percentage, int seats)
        {
            Party = party;
            Votes = votes;
            Percentage = percentage;
            Seats = seats;
        }
    }
}
