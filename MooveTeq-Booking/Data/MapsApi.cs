using System;
using System.Linq;
using System.Threading.Tasks;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using static GoogleMapsApi.GoogleMaps;

namespace MooveTeqBooking.Data {
    internal static class MapsApi {
        /// <summary>
        /// Returns the distance in meters between two physical places or addresses.
        /// </summary>
        /// <param name="originAddress">A string representing the origin address.</param>
        /// <param name="destinationAddress">A string representing the destination address.</param>
        /// <returns>An integer representing the distance in meters</returns>
        public static async Task<int> GetDistanceBetweenTwoAddresses(string originAddress, string destinationAddress) {
            var directionsRequest = new DirectionsRequest() {
                Origin = originAddress,
                Destination = destinationAddress,

                // Have fun maxing out my API key, it's on a trial month without actual payment anyways ;)
                ApiKey = "AIzaSyCtdj4v-sr8-8x9-qtoOTSyKU9KFq8Vao8"
            };

            // ReSharper disable once PossibleNullReferenceException
            var directions = await Directions.QueryAsync(directionsRequest);

            if (directions != null && directions.Status != DirectionsStatusCodes.OK) {
                throw new Exception(directions.Status.ToString());
            }

            return directions.Routes.First().Legs.First().Distance.Value;
        }
    }
}
