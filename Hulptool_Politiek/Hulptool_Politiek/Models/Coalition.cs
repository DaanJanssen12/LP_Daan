using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    class Coalition
    {
        public string Name { get; private set; }
        public Politician Premier { get; private set; }
        public List<Party> Parties { get; private set; }

        public Coalition(string name, List<Party> parties)
        {
            Name = name;
            Parties = parties;
        }
    }
}
