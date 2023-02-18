using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCodingChallenge.Domain.Entities;

namespace FinalCodingChallenge.Business.Repositories
{
    public interface IPassengerBA
    {
        Task<string> AddPassengerAsync(Passenger passenger);
        Task<string> UpdatePassengerAsync(int passengerID, int FlightID);
    }
}
