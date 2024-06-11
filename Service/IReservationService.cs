using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation? GetReservation(int id);
        void AddReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);
    }
}
