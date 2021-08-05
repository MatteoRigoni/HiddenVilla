using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public class HotelRoomService : IHotelRoomService
    {
        private readonly HttpClient _client;

        public HotelRoomService(HttpClient client)
        {
            _client = client;
        }

        public async Task<HotelRoomDto> GetHotelRoomDetail(int roomId, string checkinDate, string checkoutDate)
        {
            var response = await _client.GetAsync($"api/hotelroom/{roomId}?checkinDate={checkinDate}&checkoutDate={checkoutDate}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var room = JsonConvert.DeserializeObject<HotelRoomDto>(content);
                return room;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<HotelRoomDto>> GetHotelRooms(string checkinDate, string checkoutDate)
        {
            var response = await _client.GetAsync($"api/hotelroom?checkinDate={checkinDate}&checkoutDate={checkoutDate}");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelRoomDto>>(content);
            return rooms;
        }
    }
}
