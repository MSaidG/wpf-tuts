using MVVMSing.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMSing.ViewModel
{
    internal class ReservationListingViewModel : ViewModelBase
    {
        public ICommand MakeReservationCommand { get; set; }
        
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;


        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1,2), "SingletonSean", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1,2), "Joe", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1,2), "Mary", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1,2), "Jack", DateTime.Now, DateTime.Now)));
        }
    }
}
