using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBinding.SortingGroups
{
    public class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Category category;

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public Animal(string name, Category category)
        {
            this.name = name;
            this.category = category;
        }
    }
}
