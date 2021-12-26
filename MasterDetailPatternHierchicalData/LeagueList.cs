using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailPatternHierchicalData
{
    public class LeagueList : ObservableCollection<League>
    {
        public LeagueList()
        {
            League l;
            Division d;

            Add(l = new League($"{nameof(League)} A"));
            l.Divisions.Add(d = new Division($"{nameof(Division)} A"));
            d.Teams.Add(new Team($"{nameof(Team)} I"));
            d.Teams.Add(new Team($"{nameof(Team)} II"));
            d.Teams.Add(new Team($"{nameof(Team)} III"));
            d.Teams.Add(new Team($"{nameof(Team)} IV"));
            d.Teams.Add(new Team($"{nameof(Team)} V"));

            l.Divisions.Add((d = new Division("Division B")));
            d.Teams.Add(new Team($"{nameof(Team)} Blue"));
            d.Teams.Add(new Team($"{nameof(Team)} Red"));
            d.Teams.Add(new Team($"{nameof(Team)} Yellow"));
            d.Teams.Add(new Team($"{nameof(Team)} Green"));
            d.Teams.Add(new Team($"{nameof(Team)} Orange"));

            l.Divisions.Add((d = new Division("Division C")));
            d.Teams.Add(new Team($"{nameof(Team)} East"));
            d.Teams.Add(new Team($"{nameof(Team)} West"));
            d.Teams.Add(new Team($"{nameof(Team)} North"));
            d.Teams.Add(new Team($"{nameof(Team)} South"));

            Add(l = new League("League B"));
            l.Divisions.Add((d = new Division("Division Alfa")));
            d.Teams.Add(new Team($"{nameof(Team)} 1"));
            d.Teams.Add(new Team($"{nameof(Team)} 2"));
            d.Teams.Add(new Team($"{nameof(Team)} 3"));
            d.Teams.Add(new Team($"{nameof(Team)} 4"));
            d.Teams.Add(new Team($"{nameof(Team)} 5"));
            l.Divisions.Add((d = new Division("Division Beta")));
            d.Teams.Add(new Team($"{nameof(Team)} Diamond"));
            d.Teams.Add(new Team($"{nameof(Team)} Heart"));
            d.Teams.Add(new Team($"{nameof(Team)} Club"));
            d.Teams.Add(new Team($"{nameof(Team)} Spade"));
            l.Divisions.Add((d = new Division("Division Gama")));
            d.Teams.Add(new Team($"{nameof(Team)} Alpha"));
            d.Teams.Add(new Team($"{nameof(Team)} Beta"));
            d.Teams.Add(new Team($"{nameof(Team)} Gamma"));
            d.Teams.Add(new Team($"{nameof(Team)} Delta"));
            d.Teams.Add(new Team($"{nameof(Team)} Epsilon"));
        }
    }
}
