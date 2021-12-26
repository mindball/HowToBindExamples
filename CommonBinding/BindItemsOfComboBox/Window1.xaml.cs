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

namespace CommonBinding.BindItemsOfComboBox
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

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            //
            //GreekGod greekGod = (GreekGod)(comboBoxExample.Items[0]);
            //comboBoxExample.IsDropDownOpen = true;
            ComboBoxItem cb1 = (ComboBoxItem)(comboBoxExample.ItemContainerGenerator.ContainerFromIndex(0));
            //ComboBox cb2 = (ComboBoxItem)(comboBoxExample.ItemContainerGenerator.ContainerFromItem(comboBoxExample.Items.CurrentItem));

            comboBoxExample.IsDropDownOpen = false;
        }
    }
}
