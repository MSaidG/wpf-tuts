using MVVMSing.Model;

namespace MVVMSing.Services.ReservationProviders
{
    internal interface IReservationProvider
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
    }
}
