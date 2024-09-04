﻿using MVVMSing.Model;
using MVVMSing.ViewModel;
using System.Windows;

namespace MVVMSing.Commands
{
    internal class LoadReservationsCommand : AsyncCommandBase
    {
        private readonly ReservationListingViewModel _viewModel;
        private readonly Hotel _hotel;

        public LoadReservationsCommand(ReservationListingViewModel viewModel, Hotel hotel)
        {
            _viewModel = viewModel;
            _hotel = hotel;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                IEnumerable<Reservation> reservations = await _hotel.GetAllReservations();

                _viewModel.UpdateReservations(reservations);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reservations.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
