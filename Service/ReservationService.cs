using BusinessObject;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository reservationRepository;

        public ReservationService()
        {
            reservationRepository = new ReservationRepository();
        }

        public void AddReservation(Reservation reservation) => reservationRepository.AddReservation(reservation);

        public void DeleteReservation(int id) => reservationRepository.RemoveReservation(id);

        public Reservation? GetReservation(int id) => reservationRepository.GetReservationById(id);

        public List<Reservation> GetReservations() => reservationRepository.GetReservations();

        public void UpdateReservation(Reservation reservation) => reservationRepository.UpdateReservation(reservation);
    }
}
