﻿using MVVMSing.Model;
using MVVMSing.Store;
using MVVMSing.ViewModel;
using System.Windows;

namespace MVVMSing.Commands
{
    internal class LoadReservationsCommand : AsyncCommandBase
    {
        private readonly ReservationListingViewModel _viewModel;
        private readonly HotelStore _hotelStore;

        public LoadReservationsCommand(ReservationListingViewModel viewModel, HotelStore hotelStore)
        {
            _viewModel = viewModel;
            _hotelStore = hotelStore;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                await _hotelStore.Load();
                _viewModel.UpdateReservations(_hotelStore.Reservations);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reservations.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
