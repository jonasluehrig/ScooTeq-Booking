using System.Collections.Generic;

namespace ScooTeqBooking.Data {
    public class Customer {
        public int CustomerId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public bool IsAdmin { get; set; }

        public virtual List<Booking> Bookings { get; } = new List<Booking>();
    }
}
