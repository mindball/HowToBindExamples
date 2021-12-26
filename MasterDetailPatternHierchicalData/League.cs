using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailPatternHierchicalData
{
    public class League
    {
        public League(string name)
        {
            Name = name; ;
            Divisions = new DivisionList();           
        }

        public string Name { get; }

        public DivisionList Divisions { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
