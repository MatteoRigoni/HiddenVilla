using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDto> CreateHotelRoom(HotelRoomDto hotelRoomDto);
        public Task<HotelRoomDto> UpdateHotelRoom(int roomId, HotelRoomDto hotelRoomDto);
        public Task<HotelRoomDto> GetHotelRoom(int roomId, string checkinDate = null, string checkoutDate = null);
        public Task<int> DeleteHotelRoom(int roomId);
        public Task<IEnumerable<HotelRoomDto>> GetAllHotelRooms(string checkinDate = null, string checkoutDate = null);
        public Task<bool> IsHotelNameAlreadyPresent(string name, int roomId=0);
        public Task<bool> IsRoomBooked(int roomId, string checkinDate, string checkoutDate);
    }
}
