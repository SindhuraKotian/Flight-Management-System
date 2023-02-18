using System;
using System.Collections.Generic;

namespace FinalCodingChallenge.Domain.Entities
{
    public partial class Passenger
    {
        public Passenger(string passengerName, int? passengerAge, int? flightId)
        {
            PassengerName = passengerName;
            PassengerAge = passengerAge;
            FlightId = flightId;
        }

        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public int? PassengerAge { get; set; }
        public int? FlightId { get; set; }

        public Flight Flight { get; set; }
    }
}
