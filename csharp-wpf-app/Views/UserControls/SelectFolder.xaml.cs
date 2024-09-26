using System.Windows;
using System.Windows.Controls;

namespace csharp_wpf_app.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour SelectFolder.xaml
    /// </summary>
    public partial class SelectFolder : UserControl
    {
        public SelectFolder()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, RoutedEventArgs e)
        {
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.ShowDialog();
        }
    }
}
