using System;
using System.Collections;
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

namespace csharp_wpf_app.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour ListV.xaml
    /// </summary>
    public partial class ListV : UserControl
    {
        public ListV()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            listV.Items.Add(txtList.Text);
            txtList.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //int index = listV.SelectedIndex;
            var items = listV.SelectedItems;
            var response = MessageBox.Show($"Do you want to delete {items.Count} items ?", "Sure ?", MessageBoxButton.YesNo);

            if (response == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach (var item in itemsList)
                    listV.Items.Remove(item);
            }
                
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            listV.Items.Clear();
        }
    }
}
