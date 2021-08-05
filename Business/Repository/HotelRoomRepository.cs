using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HotelRoomRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<HotelRoomDto> CreateHotelRoom(HotelRoomDto hotelRoomDto)
        {
            HotelRoom hotelRoom = _mapper.Map<HotelRoomDto, HotelRoom>(hotelRoomDto);
            hotelRoom.CreatedDate = DateTime.UtcNow;
            hotelRoom.CreatedBy = "";
            var addedHotelRoom = await _db.HotelRooms.AddAsync(hotelRoom);
            await _db.SaveChangesAsync();

            return _mapper.Map<HotelRoom, HotelRoomDto>(addedHotelRoom.Entity);
        }

        public async Task<int> DeleteHotelRoom(int roomId)
        {
            var roomDetails = await _db.HotelRooms.FindAsync(roomId);
            if (roomDetails != null)
            {
                var allImages = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();

                _db.HotelRoomImages.RemoveRange(allImages);
                _db.HotelRooms.Remove(roomDetails);
                return await _db.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<IEnumerable<HotelRoomDto>> GetAllHotelRooms(string checkinDate, string checkoutDate)
        {
            try
            {
                IEnumerable<HotelRoomDto> hotelRoomDTOs =
                    _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDto>>(_db.HotelRooms.Include(x => x.HotelRoomImages));

                if (!string.IsNullOrEmpty(checkinDate) && !string.IsNullOrEmpty(checkoutDate))
                {
                    foreach (var hotelRoom in hotelRoomDTOs)
                    {
                        hotelRoom.IsBooked = await IsRoomBooked(hotelRoom.Id, checkinDate, checkoutDate);
                    }
                }

                return hotelRoomDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDto> GetHotelRoom(int roomId, string checkinDate, string checkoutDate)
        {
            try
            {
                HotelRoomDto hotelRoomDTO =
                    _mapper.Map<HotelRoom, HotelRoomDto>(
                        await _db.HotelRooms.Include(x => x.HotelRoomImages).FirstOrDefaultAsync(x => x.Id == roomId));

                if (!string.IsNullOrEmpty(checkinDate) && !string.IsNullOrEmpty(checkoutDate))
                {
                    hotelRoomDTO.IsBooked = await IsRoomBooked(roomId, checkinDate, checkoutDate);
                }

                return hotelRoomDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> IsHotelNameAlreadyPresent(string name, int roomId = 0)
        {
            try
            {
                if (roomId == 0)
                {
                    HotelRoomDto hotelRoomDTO =
                        _mapper.Map<HotelRoom, HotelRoomDto>(
                            await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));

                    return hotelRoomDTO != null;
                }
                else
                {
                    HotelRoomDto hotelRoomDTO =
                        _mapper.Map<HotelRoom, HotelRoomDto>(
                            await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()
                            && x.Id != roomId));

                    return hotelRoomDTO != null;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> IsRoomBooked(int roomId, string checkinDateStr, string checkoutDateStr)
        {
            try
            {
                if (!string.IsNullOrEmpty(checkoutDateStr) && !string.IsNullOrEmpty(checkinDateStr))
                {
                    DateTime checkinDate = DateTime.ParseExact(checkinDateStr, "MM/dd/yyyy", null);
                    DateTime checkoutDate = DateTime.ParseExact(checkoutDateStr, "MM/dd/yyyy", null);

                    var existingBooking = await _db.RoomOderDetail.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
                                           ((checkinDate < x.CheckoutDate && checkinDate.Date > x.CheckinDate)
                                           || (checkoutDate.Date > x.CheckinDate.Date && checkoutDate.Date < x.CheckinDate.Date)
                                           )).FirstOrDefaultAsync();

                    if (existingBooking != null)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<HotelRoomDto> UpdateHotelRoom(int roomId, HotelRoomDto hotelRoomDto)
        {
            try
            {
                if (roomId == hotelRoomDto.Id)
                {
                    // valid
                    var roomDetails = await _db.HotelRooms.FindAsync(roomId);
                    var room = _mapper.Map<HotelRoomDto, HotelRoom>(hotelRoomDto, roomDetails);
                    room.UpdatedBy = "";
                    room.UpdatedDate = DateTime.UtcNow;
                    var updatedRoom = _db.HotelRooms.Update(room);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<HotelRoom, HotelRoomDto>(updatedRoom.Entity);
                }
                else
                {
                    // invalid
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
