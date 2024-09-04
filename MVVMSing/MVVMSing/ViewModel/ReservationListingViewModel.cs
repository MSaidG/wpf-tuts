using MVVMSing.Commands;
using MVVMSing.Model;
using MVVMSing.Services;
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


        public ReservationListingViewModel(Hotel hotel, NavigationService makeReservationNavigationService)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            LoadReservationsCommand = new LoadReservationsCommand(this, hotel);
            MakeReservationsCommand = new NavigateCommand(makeReservationNavigationService);
        }

        public static ReservationListingViewModel LoadViewModel(Hotel hotel, NavigationService makeReservationNavigationService)
        {
            ReservationListingViewModel viewModel = new ReservationListingViewModel(hotel, makeReservationNavigationService);

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
