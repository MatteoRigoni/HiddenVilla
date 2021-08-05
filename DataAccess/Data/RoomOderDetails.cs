using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class RoomOderDetails
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
        [ForeignKey("RoomId")]
        public HotelRoom HotelRoom { get; set; }
        public string Status { get; set; }
    }
}
