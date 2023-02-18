using System;
using System.Collections.Generic;

namespace FinalCodingChallenge.Domain.Models
{
    public partial class FlightModel
    {
        public FlightModel(int flightId, string flightName)
        {
            FlightId = flightId;
            FlightName = flightName;
        }

        public int FlightId { get; set; }
        public string FlightName { get; set; }
    }
}
