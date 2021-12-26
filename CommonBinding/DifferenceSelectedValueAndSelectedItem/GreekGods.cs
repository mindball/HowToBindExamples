using System.Collections.ObjectModel;

namespace CommonBinding.DifferenceSelectedValueAndSelectedItem
{
    public class GreekGods : ObservableCollection<GreekGod>
    {
        public GreekGods()
        {
            Add(new GreekGod("Aphrodite", "DAf"));
            Add(new GreekGod("Apollo", "DAp"));           
            Add(new GreekGod("Poseidon", "Dpos"));
            Add(new GreekGod("Zeus", "Dze"));
        }
    }
}
