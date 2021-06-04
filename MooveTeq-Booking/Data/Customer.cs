using System.Collections.Generic;

namespace MooveTeqBooking.Data {
    public class Customer {
        public int CustomerId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public bool IsAdmin { get; set; }

        public List<Booking> Bookings { get; } = new List<Booking>();
    }
}
