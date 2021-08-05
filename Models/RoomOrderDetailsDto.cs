using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RoomOrderDetailsDto
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string StripeSessionId { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime ActualCheckoutDate { get; set; }
        public double TotalCost { get; set; }
        [Required]
        public int RoomId { get; set; }
        public bool IsPaymentSuccessful { get; set; } = false;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public HotelRoomDto HotelRoomDto { get; set; }
        public string Status { get; set; }
    }
}
