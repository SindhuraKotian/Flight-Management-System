using FinalCodingChallenge.DataAccess.Repositories;
using FinalCodingChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCodingChallenge.DataAccess.Services
{
    public class FlightDA : IFlightDA
    {
        FlightMgmtSystemDBContext FlightMgmtSystemDBContext = new FlightMgmtSystemDBContext();
        public async Task<List<Flight>> GetFlightsAsync()
        {
            List<Flight> list = null;
            try
            {
                list = await FlightMgmtSystemDBContext.Flight.ToListAsync();
                if (list == null)
                {
                    throw new FlightsNotFoundException("No Flight are Avaiable");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return list;
        }

        public async Task<List<Passenger>> GetPassengersAsync(string flightName)
        {
            List<Passenger> list = new List<Passenger>();
            int flightId = 0;
            try
            {
                List<Flight> flights = await FlightMgmtSystemDBContext.Flight.Where(a=> a.FlightName.Equals(flightName)).ToListAsync();
                flightId = flights[0].FlightId;
                if(flightId == 0)
                {
                    throw new FlightsNotFoundException("Flight not available");
                }
                List<Passenger> passengerList = await FlightMgmtSystemDBContext.Passenger.ToListAsync();
                foreach (Passenger item in passengerList)
                {
                    if (item.FlightId == flightId)
                    {
                        list.Add(item);
                    }
                }
                if (list == null)
                {
                    throw new NoPassengersException("No Passengers booked");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return list;
        }
    }
}
