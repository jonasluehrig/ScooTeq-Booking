using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooveTeqBooking.Data {
    public class DistanceChosenEventArgs : EventArgs {
        public DistanceChosenEventArgs(bool cancelled, float chosenDistance = 0) {
            Cancelled = cancelled;
            ChosenDistance = chosenDistance;
        }

        public bool Cancelled { get; internal set; }

        public float ChosenDistance { get; internal set; }
    }
}
