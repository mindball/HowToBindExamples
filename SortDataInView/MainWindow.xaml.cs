using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SortDataInView
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

        private bool IsDescending = true;

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if(IsDescending)
            {
                myListBox.Items.SortDescriptions.Clear();
                myListBox.Items.SortDescriptions.Add(
                    new SortDescription("Content", ListSortDirection.Descending));
                IsDescending = false;
                sortButton.Content = "Sorted in Ascending";
            }
            else
            {
                myListBox.Items.SortDescriptions.Clear();
                myListBox.Items.SortDescriptions.Add(
                    new SortDescription("Content", ListSortDirection.Ascending));
                IsDescending = true;
                sortButton.Content = "Sorted in Desc";
            }
        }
    }
}
