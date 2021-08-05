using Business.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HIddenVilla_API.Controllers
{
    [Route("api/[controller]")]
    public class HotelRoomController : Controller
    {
        private readonly IHotelRoomRepository _hotelRoomRepository;

        public HotelRoomController(IHotelRoomRepository hotelRoomRepository)
        {
            _hotelRoomRepository = hotelRoomRepository;
        }
        
        //[Authorize(Roles = Common.SD.ROLE_ADMIN)]
        [HttpGet]
        public async Task<IActionResult> GetHotelRooms(string checkinDate = null, string checkoutDate = null)
        {
            if (string.IsNullOrEmpty(checkinDate) || string.IsNullOrEmpty(checkoutDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "All parameters must be supplied!"
                });
            }

            if (!DateTime.TryParseExact(checkinDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckInDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid checkin date format, must be MM/dd/yyyy"
                });
            }
            if (!DateTime.TryParseExact(checkoutDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckOutDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid checkout date format, must be MM/dd/yyyy"
                });
            }

            var allRooms = await _hotelRoomRepository.GetAllHotelRooms();
            return Ok(allRooms);
        }

        [HttpGet("{roomId}")]
        public async Task<IActionResult> GetHotelRoom(int? roomId, string checkinDate = null, string checkoutDate = null)
        {
            if (roomId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "Invalid data",
                    ErrorMessage = "Invalid room id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var roomDetails = await _hotelRoomRepository.GetHotelRoom(roomId.Value);
            if (roomDetails == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "Room not found",
                    ErrorMessage = "Invalid room id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(roomDetails);

        }
    }
}
