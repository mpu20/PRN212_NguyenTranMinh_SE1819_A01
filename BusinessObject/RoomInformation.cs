﻿namespace BusinessObject
{
    public class RoomInformation
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomDescription { get; set; }
        public int RoomMaxCapacity { get; set; }
        public int RoomStatus { get; set; }
        public decimal RoomPricePerDate { get; set; }
        public int RoomTypeID { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}
