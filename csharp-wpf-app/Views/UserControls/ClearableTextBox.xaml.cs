using System.Windows;
using System.Windows.Controls;

namespace csharp_wpf_app.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get {
                return placeholder;
            }
            set {
                placeholder = value;
                tbPlaceholder.Text = placeholder;
            }
        }


        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
