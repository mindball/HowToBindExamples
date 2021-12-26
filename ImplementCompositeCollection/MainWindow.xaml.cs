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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImplementCompositeCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetItem(object sender, RoutedEventArgs e)
        {
            
            ListBoxItem lbi2 = (ListBoxItem)(myListBox.ItemContainerGenerator.ContainerFromItem(myListBox.Items.CurrentItem));

            ListBoxItem lbi1 = (ListBoxItem)(myListBox.ItemContainerGenerator.ContainerFromIndex(0));

            GreekGod greekGod = (GreekGod)myListBox.SelectedItem;

            if (greekGod == null) return;
            MessageBox.Show(greekGod.Name);

            ;
        }    
    }
}
