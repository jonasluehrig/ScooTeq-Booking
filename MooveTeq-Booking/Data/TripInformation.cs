using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooveTeqBooking.Data {
    public class TripInformation {

        /// <summary>
        /// Types by which a trip cost can be billed.
        /// </summary>
        public enum BookingType {
            ByTime = 1,
            ByDistance = 2
        }

        public BookingType BillTripBy { get; set; }
        public double? DrivenDistance { get; set; }
        public double? TotalDistance { get; set; }
        public TimeSpan? TotalTime { get; set; }
        public DateTime TripStartTime { get; set; }
        public DateTime TripEndTime { get; set; }
    }
}
