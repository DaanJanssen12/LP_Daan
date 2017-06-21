using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hulptool_Politiek.DAL;

namespace Hulptool_Politiek.Models
{
    public class Politician
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Politician(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public Politician(int id, ISql sql)
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
