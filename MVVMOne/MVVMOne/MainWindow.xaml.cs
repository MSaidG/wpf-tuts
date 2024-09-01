using MVVMOne.ViewModel;
using System.Windows;

namespace MVVMOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowsViewModel vm = new MainWindowsViewModel();
            DataContext = vm;
        }
    }
}