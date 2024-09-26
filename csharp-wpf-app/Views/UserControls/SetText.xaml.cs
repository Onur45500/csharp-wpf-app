using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace csharp_wpf_app.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour SetText.xaml
    /// </summary>
    public partial class SetText : UserControl, INotifyPropertyChanged
    {
        public SetText()
        {
            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private string boundText;

        public string BoundText
        {
            get
            {
                return boundText;
            }
            set
            {
                boundText = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
