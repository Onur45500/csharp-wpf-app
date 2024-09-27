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

namespace csharp_wpf_app.Views.Windows
{
    /// <summary>
    /// Logique d'interaction pour ModalWindow.xaml
    /// </summary>
    public partial class ModalWindow : Window
    {
        public bool success = false;
        public string input = "";

        //public ModalWindow(Window parentWindow) // Open in the middle of the screen
        public ModalWindow()
        {
            //Owner = parentWindow; // Open in the middle of the screen
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            success = true;
            input = txtModal.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtModal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtModal.Text))
                btnOk.IsEnabled = true;
            else btnOk.IsEnabled = false;
        }
    }
}
