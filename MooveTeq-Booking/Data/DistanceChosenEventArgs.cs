using System;

namespace MooveTeqBooking.Data {
    public class DistanceChosenEventArgs : EventArgs {
        public DistanceChosenEventArgs(bool cancelled, double chosenDistance = 0) {
            Cancelled = cancelled;
            ChosenDistance = chosenDistance;
        }

        private bool Cancelled { get; set; }

        private double ChosenDistance { get; set; }
    }
}
