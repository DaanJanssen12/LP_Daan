using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hulptool_Politiek.Models;

namespace Hulptool_Politiek.DAL
{
    public interface ISql
    {
        List<Election> LoadElections();
        List<ElectionResult> LoadResultsForElection(Election election);
        List<Party> LoadAllParties();
        List<Politician> LoadAllPoliticians();

        void UpdateParty(Party newParty, string oldParty);

        void UpdateResult(ElectionResult result);

        void NewCoalition(Coalition coalition);
        List<Coalition> LoadAllCoalitions();
    }
}
