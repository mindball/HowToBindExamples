using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeDataAvailableFoBinding
{
    public class PersonWithConstructorParameters
    {
        public PersonWithConstructorParameters(string personName)
        {
            PersonName = personName;
        }

        public string PersonName { get; set; }
    }
}
