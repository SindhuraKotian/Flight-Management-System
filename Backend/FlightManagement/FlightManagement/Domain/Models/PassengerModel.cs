using System;
using System.Collections.Generic;

namespace FinalCodingChallenge.Domain.Models
{
    public partial class PassengerModel
    {
        public PassengerModel(string passengerName, int? passengerAge)
        {
            PassengerName = passengerName;
            PassengerAge = passengerAge;
        }

        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public int? PassengerAge { get; set; }
        public int? FlightId { get; set; }
        
    }
}
