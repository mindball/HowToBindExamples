using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBinding.MasterDetail
{
    public class SolarSystemPlanets : ObservableCollection<Planet>
    {
        public SolarSystemPlanets()
        {
            Add(new Planet()
            {
                Name = "Mercury",
                Diameter = 4880,
                Mass = 3.30000000,
                Orbit = 57910000,
                Image = "merglobe.gif"
            });

            Add(new Planet()
            {
                Name = "Venus",
                Diameter = 1880,
                Mass = 5.30000000,
                Orbit = 1157910000,
                Image = "venglobe.gif"
            });

            Add(new Planet()
            {
                Name = "Earth",
                Diameter = 12000.32,
                Mass = 5.90000000,
                Orbit = 149000,
                Image = "earglobe.gif"
            });
        }
    }
}
