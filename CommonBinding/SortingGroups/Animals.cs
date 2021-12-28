using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBinding.SortingGroups
{
    public class Animals
    {
        private List<Animal> animalList;

        public IEnumerable<Animal> AnimalList
        {
            get { return animalList; }
        }

        public Animals()
        {
            animalList = new List<Animal>();
            animalList.Add(new Animal("California Newt", Category.Amphibians));
            animalList.Add(new Animal("Giant Panda", Category.Bears));
            animalList.Add(new Animal("Coyote", Category.Canines));
            animalList.Add(new Animal("Golden Silk Spider", Category.Spiders));
            animalList.Add(new Animal("Mandrill", Category.Primates));
            animalList.Add(new Animal("Black Bear", Category.Bears));
            animalList.Add(new Animal("Jaguar", Category.BigCats));
            animalList.Add(new Animal("Bornean Gibbon", Category.Primates));
            animalList.Add(new Animal("African Wildcat", Category.BigCats));
            animalList.Add(new Animal("Arctic Fox", Category.Canines));
            animalList.Add(new Animal("Tomato Frog", Category.Amphibians));
            animalList.Add(new Animal("Grizzly Bear", Category.Bears));
            animalList.Add(new Animal("Dingo", Category.Canines));
            animalList.Add(new Animal("Gorilla", Category.Primates));
            animalList.Add(new Animal("Green Tree Frog", Category.Amphibians));
            animalList.Add(new Animal("Bald Uakari", Category.Primates));
            animalList.Add(new Animal("Polar Bear", Category.Bears));
            animalList.Add(new Animal("Black Widow Spider", Category.Spiders));
            animalList.Add(new Animal("Bat-Eared Fox", Category.Canines));
            animalList.Add(new Animal("Cheetah", Category.BigCats));
        }
    }
}
