using System;

namespace MooveTeqBooking.Data {
    public class Booking {
        public int BookingId { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public double? TripDistance { get; set; }

        public double TotalTripCost { get; set; }

        public int? TripDiscountPercentage { get; set; }
    }
}
