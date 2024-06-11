using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoomInformationDAO
    {
        private static List<RoomInformation> roomInformations = new List<RoomInformation>
            {
                new RoomInformation { RoomID = 1, RoomNumber = "101", RoomDescription = "Single room on the first floor", RoomMaxCapacity = 1, RoomStatus = 1, RoomPricePerDate = 50.0m, RoomTypeID = 1},
                new RoomInformation { RoomID = 2, RoomNumber = "102", RoomDescription = "Double room on the first floor", RoomMaxCapacity = 2, RoomStatus = 0, RoomPricePerDate = 75.0m, RoomTypeID = 2},
                new RoomInformation { RoomID = 3, RoomNumber = "201", RoomDescription = "Suite room on the second floor", RoomMaxCapacity = 4, RoomStatus = 1, RoomPricePerDate = 200.0m, RoomTypeID = 3},
                new RoomInformation { RoomID = 4, RoomNumber = "202", RoomDescription = "Family room on the second floor", RoomMaxCapacity = 5, RoomStatus = 1, RoomPricePerDate = 150.0m, RoomTypeID = 4},
                new RoomInformation { RoomID = 5, RoomNumber = "301", RoomDescription = "Deluxe room on the third floor", RoomMaxCapacity = 3, RoomStatus = 1, RoomPricePerDate = 175.0m, RoomTypeID = 5},
                new RoomInformation { RoomID = 6, RoomNumber = "302", RoomDescription = "Twin room on the third floor", RoomMaxCapacity = 2, RoomStatus = 0, RoomPricePerDate = 80.0m, RoomTypeID = 6},
                new RoomInformation { RoomID = 7, RoomNumber = "401", RoomDescription = "Studio room on the fourth floor", RoomMaxCapacity = 2, RoomStatus = 1, RoomPricePerDate = 100.0m, RoomTypeID = 7},
                new RoomInformation { RoomID = 8, RoomNumber = "402", RoomDescription = "Economy room on the fourth floor", RoomMaxCapacity = 2, RoomStatus = 1, RoomPricePerDate = 40.0m, RoomTypeID = 8},
                new RoomInformation { RoomID = 9, RoomNumber = "501", RoomDescription = "Presidential suite on the fifth floor", RoomMaxCapacity = 6, RoomStatus = 0, RoomPricePerDate = 500.0m, RoomTypeID = 9},
                new RoomInformation { RoomID = 10, RoomNumber = "502", RoomDescription = "Accessible room on the fifth floor", RoomMaxCapacity = 2, RoomStatus = 1, RoomPricePerDate = 60.0m, RoomTypeID = 10}
            };

        public RoomInformationDAO()
        {
        }

        public static List<RoomInformation> GetRoomInformations()
        {
            return roomInformations;
        }

        public static RoomInformation? GetRoomInformationByID(int roomID)
        {
            return roomInformations.FirstOrDefault(roomInformation => roomInformation.RoomID == roomID);
        }

        public static void AddRoomInformation(RoomInformation roomInformation)
        {
            roomInformations.Add(roomInformation);
        }

        public static void UpdateRoomInformation(RoomInformation roomInformation)
        {
            RoomInformation? existingRoomInformation = roomInformations.FirstOrDefault(room => room.RoomID == roomInformation.RoomID);
            if (existingRoomInformation != null)
            {
                existingRoomInformation.RoomNumber = roomInformation.RoomNumber;
                existingRoomInformation.RoomDescription = roomInformation.RoomDescription;
                existingRoomInformation.RoomMaxCapacity = roomInformation.RoomMaxCapacity;
                existingRoomInformation.RoomStatus = roomInformation.RoomStatus;
                existingRoomInformation.RoomPricePerDate = roomInformation.RoomPricePerDate;
                existingRoomInformation.RoomTypeID = roomInformation.RoomTypeID;
            }
        }

        public static void DeleteRoomInformation(int roomID)
        {
            RoomInformation? existingRoomInformation = roomInformations.FirstOrDefault(room => room.RoomID == roomID);
            if (existingRoomInformation != null)
            {
                roomInformations.Remove(existingRoomInformation);
            }
        }
    }
}
