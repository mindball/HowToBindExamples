using CommonBinding.DataContextOrSource;
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

namespace CommonBinding
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

        private void Show_DataContextOrSource(object sender, RoutedEventArgs e)
        {
            Window1 wnd = new Window1();
            wnd.Show();
        }

        private void Show_BindingMean(object sender, RoutedEventArgs e)
        {
            WhatBindingMean.Window1 wnd = new WhatBindingMean.Window1();
            wnd.Show();
        }

        private void Show_getListBoxItemFromDataBoundListBox(object sender, RoutedEventArgs e)
        {
            GetListBoxItemfromdataboundListBox.Window1 wnd = new GetListBoxItemfromdataboundListBox.Window1();
            wnd.Show();
        }

        private void BindItemsOfComboBox_Click(object sender, RoutedEventArgs e)
        {
            BindItemsOfComboBox.Window1 wnd = new BindItemsOfComboBox.Window1();
            wnd.Show();
        }

        private void DisplayMemberPath_Click(object sender, RoutedEventArgs e)
        {
            CommonBinding.DisplayMemberPath.Window1 wnd = new DisplayMemberPath.Window1();
            wnd.Show();
        }

        private void DifferenceSelectedValueAndSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            CommonBinding.DifferenceSelectedValueAndSelectedItem.Window1 wnd = new DifferenceSelectedValueAndSelectedItem.Window1();
            wnd.Show();
        }

        private void ChangeTheLayoutOfAnItemsControl_Click(object sender, RoutedEventArgs e)
        {
            CommonBinding.ChangeTheLayoutOfAnItemsControl.Window1 wnd = new ChangeTheLayoutOfAnItemsControl.Window1();
            wnd.Show();
        }
    }
}
