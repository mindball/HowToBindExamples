using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailPatternHierchicalData
{
    public class Division
    {
        public Division(string name)
        {
            Name = name;
            Teams = new TeamList();
        }
      
        public string Name { get;  }

        public TeamList Teams { get;  }

        public override string ToString() => Name;
    }
}
