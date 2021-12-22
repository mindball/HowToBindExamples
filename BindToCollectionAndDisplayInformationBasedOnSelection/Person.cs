using System.Collections.ObjectModel;

namespace BindToCollectionAndDisplayInformationBasedOnSelection
{
    public class Person : ObservableCollection<People>
    {
        public Person() : base()
        {
            Add(
                new People
                {
                    FirstName = "Joe",
                    LastName = "Bergfams",
                    HomeTown = "Stara Zagora"
                });

            Add(new People
            {
                FirstName = "Peter",
                LastName = "Smollz",
                HomeTown = "Burgas"
            });
            Add(new People
            {
                FirstName = "Mandy",
                LastName = "FitzJerald",
                HomeTown = "Sofia"
            });
        }
    }

    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }

        public override string ToString()
        {
            return FirstName;
        }
    }
}
