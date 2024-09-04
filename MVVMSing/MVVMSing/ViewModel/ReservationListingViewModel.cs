using MVVMSing.Commands;
using MVVMSing.Model;
using MVVMSing.Services;
using MVVMSing.Store;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMSing.ViewModel
{
    internal class ReservationListingViewModel : ViewModelBase
    {
        public ICommand LoadReservationsCommand { get; set; }
        public ICommand MakeReservationsCommand { get; set; }

        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;


        public ReservationListingViewModel(HotelStore hotelStore, NavigationService makeReservationNavigationService)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            LoadReservationsCommand = new LoadReservationsCommand(this, hotelStore);
            MakeReservationsCommand = new NavigateCommand(makeReservationNavigationService);
        }

        public static ReservationListingViewModel LoadViewModel(HotelStore hotelStore, NavigationService makeReservationNavigationService)
        {
            ReservationListingViewModel viewModel = new ReservationListingViewModel(hotelStore, makeReservationNavigationService);

            viewModel.LoadReservationsCommand.Execute(null);
            
            return viewModel;
        }

        public void UpdateReservations(IEnumerable<Reservation> reservations)
        {
            _reservations.Clear();

            foreach (Reservation reservation in reservations)
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservations.Add(reservationViewModel);
            }
        }
    }
}
