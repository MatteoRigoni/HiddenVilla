using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public interface IRoomOrderDetailsService
    {
        public Task<RoomOrderDetailsDto> SaveRoomOrderDetails(RoomOrderDetailsDto details);
        public Task<RoomOrderDetailsDto> MarkPaymentSuccessful(RoomOrderDetailsDto details);
    }
}
