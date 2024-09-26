using System.Windows;
using System.Windows.Controls;

namespace csharp_wpf_app.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour MessageBox.xaml
    /// </summary>
    public partial class Agreement : UserControl
    {
        public Agreement()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you agree", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbStatus.Text = "Agreed";
            }
            else
            {
                tbStatus.Text = "Not agreed";
            }
        }
    }
}
