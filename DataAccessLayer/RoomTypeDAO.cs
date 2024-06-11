using BusinessObject;

namespace DataAccessLayer
{
    public class RoomTypeDAO
    {
        private static List<RoomType> roomTypes =
            [
                new RoomType { RoomTypeID = 1, RoomTypeName = "Single", TypeDescription = "Single room with one bed", TypeNote = "Suitable for one person" },
                new RoomType { RoomTypeID = 2, RoomTypeName = "Double", TypeDescription = "Double room with two beds", TypeNote = "Suitable for two people" },
                new RoomType { RoomTypeID = 3, RoomTypeName = "Suite", TypeDescription = "Suite room with luxurious amenities", TypeNote = "Suitable for VIP guests" },
                new RoomType { RoomTypeID = 4, RoomTypeName = "Family", TypeDescription = "Family room with multiple beds", TypeNote = "Suitable for families" },
                new RoomType { RoomTypeID = 5, RoomTypeName = "Deluxe", TypeDescription = "Deluxe room with superior facilities", TypeNote = "Suitable for high-end guests" },
                new RoomType { RoomTypeID = 6, RoomTypeName = "Twin", TypeDescription = "Twin room with two single beds", TypeNote = "Suitable for two individuals" },
                new RoomType { RoomTypeID = 7, RoomTypeName = "Studio", TypeDescription = "Studio room with a kitchenette", TypeNote = "Suitable for extended stays" },
                new RoomType { RoomTypeID = 8, RoomTypeName = "Economy", TypeDescription = "Economy room with basic facilities", TypeNote = "Suitable for budget travelers" },
                new RoomType { RoomTypeID = 9, RoomTypeName = "Presidential", TypeDescription = "Presidential suite with the best facilities", TypeNote = "Suitable for high-profile guests" },
                new RoomType { RoomTypeID = 10, RoomTypeName = "Accessible", TypeDescription = "Accessible room with special facilities", TypeNote = "Suitable for guests with disabilities" }
            ];

        public RoomTypeDAO()
        {
        }

        public static List<RoomType> GetRoomTypes()
        {
            return roomTypes;
        }

        public static RoomType? GetRoomTypeByID(int roomTypeID)
        {
            return roomTypes.FirstOrDefault(roomType => roomType.RoomTypeID == roomTypeID);
        }

        public static void AddRoomType(RoomType roomType)
        {
            roomTypes.Add(roomType);
        }

        public static void UpdateRoomType(RoomType roomType)
        {
            RoomType? existingRoomType = GetRoomTypeByID(roomType.RoomTypeID);
            if (existingRoomType != null)
            {
                existingRoomType.RoomTypeName = roomType.RoomTypeName;
                existingRoomType.TypeDescription = roomType.TypeDescription;
                existingRoomType.TypeNote = roomType.TypeNote;
            }
        }

        public static void DeleteRoomType(int roomTypeID)
        {
            RoomType? existingRoomType = GetRoomTypeByID(roomTypeID);
            if (existingRoomType != null)
            {
                roomTypes.Remove(existingRoomType);
            }
        }
    }
}
