using MVVMSing.Model;

namespace MVVMSing.Services.ReservationConflictValidators
{
    internal interface IReservationConflictValidator
    {
        Task<Reservation> GetConflictingReservation(Reservation reservation);
    }
}
