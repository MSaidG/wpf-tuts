using MVVMSing.Commands;
using MVVMSing.Model;
using MVVMSing.Services;
using MVVMSing.Store;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Windows.Input;

namespace MVVMSing.ViewModel
{
    internal class ReservationListingViewModel : ViewModelBase
    {
        private readonly Hotel _hotel;
        public ICommand MakeReservationCommand { get; set; }

        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;


        public ReservationListingViewModel(Hotel hotel, NavigationService makeReservationNavigationService)
        {
            _hotel = hotel;
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);

            UpdateReservations();
        }

        private void UpdateReservations()
        {
            _reservations.Clear();

            foreach (Reservation reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservations.Add(reservationViewModel);
            }
        }
    }
}
