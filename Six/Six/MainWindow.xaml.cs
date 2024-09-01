using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Six
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

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            // MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement",
            //     MessageBoxButton.YesNo, MessageBoxImage.Question);
            // 
            // if (result == MessageBoxResult.Yes)
            // {
            //     tbInfo.Text = "Agreed";
            // }
            // else
            // {
            //     tbInfo.Text = "Not Agreed";
            // }

            // ---------------------------------------------------------------------

            // OpenFileDialog fileDialog = new OpenFileDialog();
            // fileDialog.Filter = "C# Source Files | *.cs";
            // fileDialog.InitialDirectory = "C:\\";
            // fileDialog.Title = "Select cs files";
            // fileDialog.Multiselect = true;
            // 
            // bool? success = fileDialog.ShowDialog();
            // if (success == true)
            // {
            //     string[] paths = fileDialog.FileNames;
            //     string[] fileNames = fileDialog.SafeFileNames;
            //     //tbInfo.Text = fileName;
            // }

            OpenFolderDialog dialog = new OpenFolderDialog();
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            
            bool? success  = dialog.ShowDialog();
            if (success == true)
            {
                string folder = dialog.FolderName;
                tbInfo.Text = folder;
            }
        }
    }
}