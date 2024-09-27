using csharp_wpf_app.Views.Windows;
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

namespace csharp_wpf_app.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour OpenModalWindow.xaml
    /// </summary>
    public partial class OpenModalWindow : UserControl
    {
        public OpenModalWindow()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            //ModalWindow modalWindow = new ModalWindow(this); // To open in the center of the screen
            ModalWindow modalWindow = new ModalWindow();
            modalWindow.ShowDialog();
            if (modalWindow.success)
            {
                txtSet.Text = modalWindow.input;
            }
        }
    }
}
