﻿namespace MVVMSing.Model
{
    internal class Reservation
    {
        public RoomID RoomID { get; }
        public string Username { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public TimeSpan Length => EndDate.Subtract(StartDate);

        public Reservation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StartDate = startTime;
            EndDate = endTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.StartDate <EndDate || reservation.EndDate > StartDate;
        }
    }
}
