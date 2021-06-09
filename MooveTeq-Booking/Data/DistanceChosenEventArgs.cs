using System;

namespace MooveTeqBooking.Data {
    public class DistanceChosenEventArgs : EventArgs {
        public DistanceChosenEventArgs(bool cancelled, double chosenDistance = 0) {
            Cancelled = cancelled;
            ChosenDistance = chosenDistance;
        }

        public bool Cancelled { get; internal set; }

        public double ChosenDistance { get; internal set; }
    }
}
