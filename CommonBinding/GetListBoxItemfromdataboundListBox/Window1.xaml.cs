using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CommonBinding.GetListBoxItemfromdataboundListBox
{

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

        }

        private void showItem_Click(object sender, RoutedEventArgs e)
        {
            GreekGod greekGod = (GreekGod)listBoxGods.SelectedItem;

            if (greekGod == null) return;
            MessageBox.Show(greekGod.Name);
        }

        private void showItemFromIndex_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi1 = (ListBoxItem)(listBoxGods.ItemContainerGenerator.ContainerFromIndex(0));            
        }

        private void showItemWithCurrentItem_Click_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi2 = (ListBoxItem)(listBoxGods.ItemContainerGenerator.ContainerFromItem(listBoxGods.Items.CurrentItem));
        }
    }
}
