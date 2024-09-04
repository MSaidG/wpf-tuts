using MVVMSing.Model;

namespace MVVMSing.Store
{
    internal class HotelStore
    {
        private readonly Hotel _hotel;
        private readonly List<Reservation> _reservations;
        private readonly Lazy<Task> _initializeLazy;
        public IEnumerable<Reservation> Reservations => _reservations;

        public HotelStore(Hotel hotel)
        {
            _hotel = hotel;
            _reservations = new List<Reservation>();
            _initializeLazy = new Lazy<Task>(Initialize);
        }

        public async Task Load()
        {
            await _initializeLazy.Value;
        }


        public async Task MakeReservation(Reservation reservation)
        {
            await _hotel.MakeReservation(reservation);

            _reservations.Add(reservation);
        }

        private async Task Initialize()
        {
            IEnumerable<Reservation> reservations = await _hotel.GetAllReservations();

            _reservations.Clear();
            _reservations.AddRange(reservations);
        }

    }
}
