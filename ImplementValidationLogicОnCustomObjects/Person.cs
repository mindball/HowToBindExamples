using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementValidationLogicОnCustomObjects
{
    public class Person : IDataErrorInfo
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string this[string columnName] 
        {
            get
            {
                string result = null;

                if (columnName == "Age")
                {
                    if (age < 0 || age > 150)
                    {
                        result = "Age must not be less than 0 or greater tha 150";
                    } 
                }
                return result;
            }
        }

        public string Error 
        {
            get => null;
        }
    }
}
