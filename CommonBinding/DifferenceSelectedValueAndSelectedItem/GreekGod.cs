namespace CommonBinding.DifferenceSelectedValueAndSelectedItem
{ 
    public class GreekGod
    {
        public GreekGod(string name, string description)
        {            
            Name= name;
            Description= description;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string RomanName { get; set; }
    }
}
