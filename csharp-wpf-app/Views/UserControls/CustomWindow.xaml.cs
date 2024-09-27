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
    /// Logique d'interaction pour CustomWindow.xaml
    /// </summary>
    public partial class CustomWindow : UserControl
    {
        public CustomWindow()
        {
            InitializeComponent();
        }

        //private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //private void btnClose_Click(object sender, RoutedEventArgs e)
        //{
        //    //Close(); // to close only the window
        //    Application.Current.Shutdown(); // to close the actual page
        //}

        //private void btnMinimize_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void btnMaximize_Click(object sender, RoutedEventArgs e)
        //{
        //    if (WindowState == WindowState.Maximized)
        //        WindowState = WindowState.Normal;
        //    else
        //        WindowState = WindowState.Maximized;
        //}
    }
}
