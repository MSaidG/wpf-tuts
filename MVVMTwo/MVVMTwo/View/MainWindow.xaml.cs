using MVVMTwo.Model;
using MVVMTwo.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace MVVMTwo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel viewModel = new MainWindowViewModel();
            DataContext = viewModel;
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            userList.Items.Filter = Search;
        }

        private bool Search(object obj)
        {
            var user = (User)obj;

            return user.Name.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}