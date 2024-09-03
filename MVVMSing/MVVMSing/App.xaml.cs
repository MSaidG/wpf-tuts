﻿using MVVMSing.Exceptions;
using MVVMSing.Model;
using MVVMSing.Services;
using MVVMSing.Store;
using MVVMSing.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MVVMSing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("Singleton Suites");
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateReservationViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, new NavigationService(_navigationStore, CreateReservationViewModel));
        }

        private ReservationListingViewModel CreateReservationViewModel()
        {
            return new ReservationListingViewModel(_hotel, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }

}
