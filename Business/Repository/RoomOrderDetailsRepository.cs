using AutoMapper;
using Business.Repository.IRepository;
using Common;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class RoomOrderDetailsRepository : IRoomOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public RoomOrderDetailsRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<RoomOrderDetailsDto> Create(RoomOrderDetailsDto details)
        {
            try
            {
                details.CheckinDate = details.CheckinDate.Date;
                details.CheckoutDate = details.CheckoutDate.Date;
                var roomOrder = _mapper.Map<RoomOrderDetailsDto, RoomOderDetails>(details);
                roomOrder.Status = SD.STATUS_PENDING;
                var result = await _db.RoomOderDetail.AddAsync(roomOrder);
                await _db.SaveChangesAsync();

                return _mapper.Map<RoomOderDetails, RoomOrderDetailsDto>(result.Entity);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<RoomOrderDetailsDto>> GetAllRoomOrderDetails()
        {
            try
            {
                IEnumerable<RoomOrderDetailsDto> roomOrders = _mapper.Map<IEnumerable<RoomOderDetails>, IEnumerable<RoomOrderDetailsDto>>
                    (_db.RoomOderDetail.Include(u => u.HotelRoom));

                return roomOrders;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<RoomOrderDetailsDto> GetRoomOrderDetail(int roomOrderId)
        {
            try
            {
                RoomOderDetails roomOrder = await _db.RoomOderDetail
                    .Include(u => u.HotelRoom).ThenInclude(x => x.HotelRoomImages)
                    .FirstOrDefaultAsync(u => u.Id == roomOrderId);

                RoomOrderDetailsDto roomOrderDetailsDto = _mapper.Map<RoomOderDetails, RoomOrderDetailsDto>(roomOrder);
                roomOrderDetailsDto.HotelRoomDto.TotalDays = (roomOrderDetailsDto.CheckoutDate - roomOrderDetailsDto.CheckinDate).Days;

                return roomOrderDetailsDto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        

        public async Task<RoomOrderDetailsDto> MarkPaymentSuccessful(int id)
        {
            var data = await _db.RoomOderDetail.FindAsync(id);
            if (data == null) return null;

            if (!data.IsPaymentSuccessful)
            {
                data.IsPaymentSuccessful = true;
                data.Status = SD.STATUS_BOOKED;
                var markPaymentSuccessful = _db.RoomOderDetail.Update(data);
                await _db.SaveChangesAsync();
                return _mapper.Map<RoomOderDetails, RoomOrderDetailsDto>(markPaymentSuccessful.Entity);
            }
            return null;
        }

        public Task<bool> UpdateOrderStatus(int roomOrderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
