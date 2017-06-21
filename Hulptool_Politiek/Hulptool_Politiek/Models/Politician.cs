using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulptool_Politiek.Models
{
    public class Politician
    {
        public string Name { get; private set; }

        public Politician(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
