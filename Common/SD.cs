using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class SD
    {
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_CUSTOMER = "Customer";
        public const string ROLE_EMPLOYEE = "Employee";

        public const string LOCAL_INITIAL_BOOKING = "LocalInitialBooking";
        public const string LOCAL_ORDER_DETAILS = "LocalOrderDetails";
        public const string LOCAL_TOKEN = "LocalToken";
        public const string LOCAL_USER_DETAIL = "LocalUserDetail";

        public const string STATUS_PENDING = "Pending";
        public const string STATUS_BOOKED = "Booked";
        public const string STATUS_CHECKIN = "CheckedIn";
        public const string STATUS_CHECKOUT = "CheckedOut";
        public const string STATUS_NOSHOW = "NoShow";
        public const string STATUS_CANCEL = "Cancelled";

    }
}
