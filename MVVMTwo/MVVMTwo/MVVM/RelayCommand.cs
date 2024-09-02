using System.Windows.Input;

namespace MVVMTwo.MVVM
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> execute { get; set; }
        private Predicate<object>? canExecute { get; set; }

        public RelayCommand(Action<object> execute, Predicate<object>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return  canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
