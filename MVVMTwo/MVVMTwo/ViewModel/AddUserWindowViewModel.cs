using MVVMTwo.Model;
using MVVMTwo.MVVM;
using System.Windows.Input;

namespace MVVMTwo.ViewModel
{
    internal class AddUserWindowViewModel
    {

        public ICommand AddUserCommand { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        public AddUserWindowViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User() { Name = Name, Email = Email });
        }
    }
}
