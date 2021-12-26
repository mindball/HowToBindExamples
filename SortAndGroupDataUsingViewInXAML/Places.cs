using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndGroupDataUsingViewInXAML
{
    public class Places : ObservableCollection<Place>
    {
        public Places()
        {
            Add(new Place { CityName = "Hrishtene", State = "StaraZagora" });
            Add(new Place { CityName = "Budeshte", State = "StaraZagora" });
            Add(new Place { CityName = "Borilovo", State = "StaraZagora" });
            Add(new Place { CityName = "Malka verey", State = "StaraZagora" });
            Add(new Place { CityName = "Meri4leri", State = "Haskovo" });
            Add(new Place { CityName = "Anton", State = "Haskovo" });
            Add(new Place { CityName = "Karlovo", State = "Plovdiv" });
            Add(new Place { CityName = "Hisar", State = "Plovdiv" });
        }
    }
   
}
