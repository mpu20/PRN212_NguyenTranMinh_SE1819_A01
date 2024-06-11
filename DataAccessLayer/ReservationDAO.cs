using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ReservationDAO
    {
        private static List<Reservation> reservations =
            [
                new Reservation { Id = 1, RoomId = 1, CustomerId = 1, CheckIn = new DateTime(2024, 6, 10), CheckOut = new DateTime(2024, 6, 15), TotalPrice = 250.0m},
                new Reservation { Id = 2, RoomId = 2, CustomerId = 1, CheckIn = new DateTime(2024, 7, 5), CheckOut = new DateTime(2024, 7, 10), TotalPrice = 375.0m},
                new Reservation { Id = 3, RoomId = 1, CustomerId = 2, CheckIn = new DateTime(2024, 8, 20), CheckOut = new DateTime(2024, 8, 25), TotalPrice = 1000.0m},
                new Reservation { Id = 4, RoomId = 2, CustomerId = 2, CheckIn = new DateTime(2024, 9, 10), CheckOut = new DateTime(2024, 9, 15), TotalPrice = 750.0m},
                new Reservation { Id = 5, RoomId = 1, CustomerId = 1, CheckIn = new DateTime(2024, 10, 1), CheckOut = new DateTime(2024, 10, 5), TotalPrice = 875.0m}
            ];

        public ReservationDAO()
        {
        }

        public static List<Reservation> GetReservations()
        {
            return reservations;
        }

        public static void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public static void RemoveReservation(int id)
        {
            var r = reservations.FirstOrDefault(x => x.Id == id);
            if (r != null) reservations.Remove(r);
        }

        public static void UpdateReservation(Reservation reservation)
        {
            Reservation? r = reservations.FirstOrDefault(x => x.Id == reservation.Id);
            if (r != null)
            {
                r.RoomId = reservation.RoomId;
                r.CustomerId = reservation.CustomerId;
                r.CheckIn = reservation.CheckIn;
                r.CheckOut = reservation.CheckOut;
            }
        }

        public static Reservation? GetReservationById(int id)
        {
            return reservations.FirstOrDefault(x => x.Id == id);
        }
    }
}
