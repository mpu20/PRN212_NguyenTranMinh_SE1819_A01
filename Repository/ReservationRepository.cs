using BusinessObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReservationRepository : IReservationRepository
    {
        public void AddReservation(Reservation reservation) => ReservationDAO.AddReservation(reservation);

        public Reservation? GetReservationById(int id) => ReservationDAO.GetReservationById(id);

        public List<Reservation> GetReservations() => ReservationDAO.GetReservations();

        public void RemoveReservation(int id) => ReservationDAO.RemoveReservation(id);

        public void UpdateReservation(Reservation reservation) => ReservationDAO.UpdateReservation(reservation);
    }
}
