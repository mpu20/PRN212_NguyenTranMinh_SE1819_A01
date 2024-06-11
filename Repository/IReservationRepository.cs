using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repository
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
        void AddReservation(Reservation reservation);
        void RemoveReservation(int id);
        void UpdateReservation(Reservation reservation);
        Reservation? GetReservationById(int id);
    }
}
