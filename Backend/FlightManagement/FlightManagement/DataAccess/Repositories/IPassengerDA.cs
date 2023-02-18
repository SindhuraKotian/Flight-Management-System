using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCodingChallenge.Domain.Entities;

namespace FinalCodingChallenge.DataAccess.Repositories
{
    public interface IPassengerDA
    {
        Task<string> AddPassengerAsync(Passenger passenger);
        Task<string> UpdatePassengerAsync(int passengerID, int flightID);
    }
}
