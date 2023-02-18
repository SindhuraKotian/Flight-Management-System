using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCodingChallenge.Domain.Entities;

namespace FinalCodingChallenge.Business.Repositories
{
    
    public interface IFlightBA
    {
        Task<List<Flight>> GetFlightsAsync();
        Task<List<Passenger>> GetPassengersAsync(string flightName);
    }
}
