using FinalCodingChallenge.Business.Repositories;
using FinalCodingChallenge.DataAccess.Repositories;
using FinalCodingChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCodingChallenge.Business.Services
{
    public class PassengerBA : IPassengerBA
    {
        private readonly IPassengerDA _passengerDA;

        public PassengerBA(IPassengerDA passengerDA)
        {
            _passengerDA = passengerDA;
        }

        public async Task<string> AddPassengerAsync(Passenger passenger)
        {
            string status = "";
            try
            {
                status = await _passengerDA.AddPassengerAsync(passenger);
            }
            catch(Exception e)
            {
                throw e;
            }
            return status;
        }

       

        public async Task<string> UpdatePassengerAsync(int passengerID, int FlightID)
        {
            string status = "";
            try
            {
                status = await _passengerDA.UpdatePassengerAsync(passengerID, FlightID);
            }
            catch (Exception e)
            {
                throw e;
            }
            return status;
        }
    }
}
