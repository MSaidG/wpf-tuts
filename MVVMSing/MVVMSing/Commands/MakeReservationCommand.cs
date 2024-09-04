using MVVMSing.Exceptions;
using MVVMSing.Model;
using MVVMSing.Services;
using MVVMSing.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMSing.Commands
{
    internal class MakeReservationCommand : AsyncCommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        private readonly NavigationService _reservationViewNavigationService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel,
                                        NavigationService reservationViewNavigationService)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _reservationViewNavigationService = reservationViewNavigationService;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName ==  nameof(MakeReservationViewModel.Username)
                || e.PropertyName == nameof(MakeReservationViewModel.FloorNumber)
                || e.PropertyName == nameof(MakeReservationViewModel.RoomNumber))
            {
                OnCanExecuteChanged();
            }
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate
                );

            try
            {
                await _hotel.MakeReservation( reservation );
                MessageBox.Show("Successfully reserved room.", "Success", 
                    MessageBoxButton.OK, MessageBoxImage.Information);

                _reservationViewNavigationService.Navigate();
            }
            catch (ReservationConflictException ex)
            {
                MessageBox.Show("The Room is already taken!", "Error", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) &&
                _makeReservationViewModel.FloorNumber > 0 && 
                _makeReservationViewModel.RoomNumber > 0 && base.CanExecute(parameter);
        }
    }
}
