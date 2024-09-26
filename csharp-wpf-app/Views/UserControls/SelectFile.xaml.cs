using System.Windows;
using System.Windows.Controls;


namespace csharp_wpf_app.Views.UserControls
{
    /// <summary>
    /// Logique d'interaction pour SelectFile.xaml
    /// </summary>
    public partial class SelectFile : UserControl
    {
        public SelectFile()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog();
            //fileDialog.Filter = "C# Source Files | *.cs"; // That will allow us to filter the files that we can select, here only csharp files
            fileDialog.Title = "Please select a file..."; // That will set the title of the modal that is launch
            fileDialog.Multiselect = true; // That will enable to select multiple files

            bool? success = fileDialog.ShowDialog();
            if (success == true)
            {
                //txtFile.Text = fileDialog.FileName; // That will show the path of file
                txtFile.Text = fileDialog.SafeFileName; // That will show only the file name
            }
            else
            {

            }
        }
    }
}
