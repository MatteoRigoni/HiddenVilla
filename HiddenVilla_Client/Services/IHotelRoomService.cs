using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public interface IHotelRoomService
    {
        public Task<IEnumerable<HotelRoomDto>> GetHotelRooms(string checkinDate, string checkoutDate);
        public Task<HotelRoomDto> GetHotelRoomDetail(int roomId, string checkinDate, string checkoutDate);
    }
}
