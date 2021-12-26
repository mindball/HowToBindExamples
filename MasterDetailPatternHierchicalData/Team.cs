using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailPatternHierchicalData
{
    public class Team
    {
        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
