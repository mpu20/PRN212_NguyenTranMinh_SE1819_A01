using BusinessObject;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NguyenTranMinhWPF
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        private Customer _customer;
        private readonly IRoomInformationService roomInformationService = new RoomInformationService();
        private readonly IReservationService reservationService = new ReservationService();

        public BookingWindow(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            DataContext = this;
            cboRoomNumber.ItemsSource = roomInformationService.GetRoomInformation().Where(ri => ri.RoomStatus == 1);
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            if (cboRoomNumber.SelectedItem is RoomInformation room && dptbCheckIn.SelectedDate.HasValue && dptbCheckOut.SelectedDate.HasValue && decimal.Parse(txtTotalPrice.Text) > 0)
            {
                var reservation = new Reservation
                {
                    Id = reservationService.GetReservations().Count() + 1,
                    CustomerId = _customer.CustomerID,
                    RoomId = room.RoomID,
                    Customer = _customer,
                    CheckIn = dptbCheckIn.SelectedDate.Value,
                    CheckOut = dptbCheckOut.SelectedDate.Value,
                    TotalPrice = decimal.Parse(txtTotalPrice.Text)
                };

                reservationService.AddReservation(reservation);
                var roomToUpdate = roomInformationService.GetRoomInformation().First(ri => ri.RoomNumber == room.RoomNumber);
                roomToUpdate.RoomStatus = 0;
                roomInformationService.UpdateRoomInformation(roomToUpdate);
                DialogResult = true;

                Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

            Close();
        }

        private void RecaculateTotalPrice(object sender, EventArgs e)
        {
            if (cboRoomNumber.SelectedItem is RoomInformation room && dptbCheckIn.SelectedDate.HasValue && dptbCheckOut.SelectedDate.HasValue)
            {
                var days = (decimal)(dptbCheckOut.SelectedDate.Value - dptbCheckIn.SelectedDate.Value).TotalDays;
                txtTotalPrice.Text = (days * room.RoomPricePerDate).ToString();
            }
        }
    }
}
