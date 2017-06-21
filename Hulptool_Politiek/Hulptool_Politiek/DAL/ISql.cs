﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hulptool_Politiek.Models;

namespace Hulptool_Politiek.DAL
{
    interface ISql
    {
        List<Election> LoadElections();
        List<ElectionResult> LoadResultsForElection(Election election);
        List<Party> LoadAllParties();
        List<Politician> LoadAllPoliticians();

        void UpdateParty(Party newParty, string oldParty);
    }
}
