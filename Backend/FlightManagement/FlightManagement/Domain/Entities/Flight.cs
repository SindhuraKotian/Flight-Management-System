using System;
using System.Collections.Generic;

namespace FinalCodingChallenge.Domain.Entities
{
    public partial class Flight
    {
        public Flight()
        {
            Passenger = new HashSet<Passenger>();
        }

        public int FlightId { get; set; }
        public string FlightName { get; set; }

        public ICollection<Passenger> Passenger { get; set; }
    }
}
