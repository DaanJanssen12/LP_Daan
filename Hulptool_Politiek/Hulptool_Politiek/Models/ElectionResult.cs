using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    public class ElectionResult
    {
        public int ResultId { get; private set; }
        public Party Party { get; private set; }
        public int Votes { get; set; }
        public double Percentage { get; set; }
        public int Seats { get; set; }

        public ElectionResult()
        {
                
        }

        public ElectionResult(Party party, int votes, double percentage, int seats, int id)
        {
            Party = party;
            Votes = votes;
            Percentage = percentage;
            Seats = seats;
            ResultId = id;
        }

        public void CalculateSeats(int votes)
        {
            Votes = votes;
            Percentage = 1;
            Seats = (Int32)Math.Round((Percentage * Seats), 0, MidpointRounding.AwayFromZero);
        }

        public override string ToString()
        {
            return Party.Abbreviation + " - stemmen: " + Votes.ToString() + " - zetels: " + Seats.ToString();
        }
    }
}
