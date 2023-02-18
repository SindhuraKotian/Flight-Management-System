using FinalCodingChallenge.DataAccess.Repositories;
using FinalCodingChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCodingChallenge.DataAccess.Services
{
    public class PassengerDA : IPassengerDA
    {
        FlightMgmtSystemDBContext FlightMgmtSystemDBContext = new FlightMgmtSystemDBContext();
        

        public async Task<string> AddPassengerAsync(Passenger passenger)
        {
            try
            {
                await FlightMgmtSystemDBContext.Passenger.AddAsync(passenger);
                await FlightMgmtSystemDBContext.SaveChangesAsync();
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return "Booking Confirmed";
        }

        public async Task<string> UpdatePassengerAsync(int passengerID, int flightID)
        {
            string passengerName = "";
            try
            {
                List<Passenger> passengerList = await FlightMgmtSystemDBContext.Passenger.Where(a => a.PassengerId.Equals(passengerID)).ToListAsync();
                passengerName = passengerList[0].PassengerName;
                passengerList[0].FlightId = flightID;
                await FlightMgmtSystemDBContext.SaveChangesAsync();
                
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return "Successfully updated the flight details for "+ passengerName ;
        }
    
    }
}
