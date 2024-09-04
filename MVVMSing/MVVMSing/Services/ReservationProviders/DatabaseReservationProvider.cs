using Microsoft.EntityFrameworkCore;
using MVVMSing.Db;
using MVVMSing.DTO;
using MVVMSing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSing.Services.ReservationProviders
{
    internal class DatabaseReservationProvider : IReservationProvider
    {
        private readonly ReservoomDbContextFactory _dbContextFactory;

        public DatabaseReservationProvider(ReservoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            using (ReservoomDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ReservationDTO> reservationDTO = await context.Reservations.ToListAsync();

                return reservationDTO.Select(r => ToReservation(r));
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
