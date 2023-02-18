using FinalCodingChallenge.Business.Repositories;
using FinalCodingChallenge.DataAccess.Repositories;
using FinalCodingChallenge.DataAccess.Services;
using FinalCodingChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCodingChallenge.Business.Services
{
    public class FlightBA : IFlightBA
    {
        private readonly IFlightDA _flightDA;

        public FlightBA(IFlightDA flightDA)
        {
            _flightDA = flightDA;
        }

        public async Task<List<Flight>> GetFlightsAsync()
        {
            List<Flight> list = null;
            try
            {
                list = await _flightDA.GetFlightsAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
            return list;
        }

        public async Task<List<Passenger>> GetPassengersAsync(string flightName)
        {
            List<Passenger> passengersList = null;
            try
            {
                passengersList = await _flightDA.GetPassengersAsync(flightName);
            }
            catch(Exception e)
            {
                throw e;
            }
            return passengersList;
        }
    }
}
