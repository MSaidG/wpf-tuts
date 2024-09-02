using MVVMTwo.Model;
using MVVMTwo.MVVM;
using MVVMTwo.View;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MVVMTwo.ViewModel
{
    internal class MainWindowViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ICommand ShowAddUserWindowCommand { get; set; }

        public MainWindowViewModel() 
        {
            Users = UserManager.GetUsers();

            ShowAddUserWindowCommand = new RelayCommand(ShowAddUserWindow);
        }

        private void ShowAddUserWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.Owner = mainWindow;
            addUserWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWindow.Show();
        }
    }
}
