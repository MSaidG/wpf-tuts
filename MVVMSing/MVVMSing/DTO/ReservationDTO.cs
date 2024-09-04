using System.ComponentModel.DataAnnotations;

namespace MVVMSing.DTO
{
    internal class ReservationDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Username  { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
