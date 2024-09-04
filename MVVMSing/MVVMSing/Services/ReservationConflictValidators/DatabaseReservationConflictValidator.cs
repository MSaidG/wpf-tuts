using Microsoft.EntityFrameworkCore;
using MVVMSing.Db;
using MVVMSing.DTO;
using MVVMSing.Model;

namespace MVVMSing.Services.ReservationConflictValidators
{
    internal class DatabaseReservationConflictValidator : IReservationConflictValidator
    {

        private readonly ReservoomDbContextFactory _dbContextFactory;

        public DatabaseReservationConflictValidator(ReservoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Reservation> GetConflictingReservation(Reservation reservation)
        {
            using (ReservoomDbContext context = _dbContextFactory.CreateDbContext())
            {
                ReservationDTO? reservationDTO = await context.Reservations
                    .Where(r => r.FloorNumber == reservation.RoomID.FloorNumber)
                    .Where(r => r.RoomNumber == reservation.RoomID.RoomNumber)
                    .Where(r => r.EndTime > reservation.StartDate)
                    .Where(r => r.StartTime < reservation.EndDate)
                    .FirstOrDefaultAsync();

                if (reservationDTO == null) return null;

                return ToReservation(reservationDTO);
            }
        }

        private static Reservation ToReservation(ReservationDTO r)
        {
            return new Reservation(
                                new RoomID(r.FloorNumber, r.RoomNumber),
                                r.Username,
                                r.StartTime,
                                r.EndTime);
        }
    }
}
