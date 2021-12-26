namespace CommonBinding.DisplayMemberPath
{ 
    public class GreekGod
    {
        public GreekGod(string name)
        {            
            Name= name;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string RomanName { get; set; }
    }
}
