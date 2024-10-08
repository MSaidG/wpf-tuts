﻿using MVVMSing.ViewModel;

namespace MVVMSing.Store
{
    internal class NavigationStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action? CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }


    }
}
