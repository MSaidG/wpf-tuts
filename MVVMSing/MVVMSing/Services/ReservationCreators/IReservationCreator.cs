using MVVMSing.Model;

namespace MVVMSing.Services.ReservationCreators
{
    internal interface IReservationCreator
    {
        Task CreateReservation(Reservation Reservation);
    }
}
