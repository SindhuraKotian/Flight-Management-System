using FinalCodingChallenge.Business.Repositories;
using FinalCodingChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCodingChallenge.Domain.Models
{
    public class ManagerModel
    {
        private readonly IPassengerBA _passengerBA;
        private readonly IFlightBA _flightBA;


        public ManagerModel(IPassengerBA passengerBA, IFlightBA flightBA)
        {
            _passengerBA = passengerBA;
            _flightBA = flightBA;
        }

        internal async Task<string> AddPassengerAsync(PassengerModel passengerModel)
        {
            string status = "";
            try
            {
                Passenger passenger = new Passenger(passengerModel.PassengerName, passengerModel.PassengerAge, passengerModel.FlightId);
                status = await _passengerBA.AddPassengerAsync(passenger);
            }
            catch (Exception e)
            {
                throw e;
            }
            return status;
        }

        internal async Task<List<FlightModel>> GetFlights()
        {
            List<FlightModel> flightList = new List<FlightModel>();
            try
            {
                List<Flight> list = await _flightBA.GetFlightsAsync();
                foreach (Flight item in list)
                {
                    FlightModel flightModel = new FlightModel(item.FlightId, item.FlightName);
                    flightList.Add(flightModel);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return flightList;
        }

        internal async Task<string> UpdatePassengerAsync(int passengerId, int flightId)
        {
            string status = "";
            try
            {
                status = await _passengerBA.UpdatePassengerAsync(passengerId, flightId);
            }
            catch(Exception e)
            {
                throw e;
            }
            return status;
        }

        internal async Task<List<PassengerModel>> GetPassengersAsync(string flightName)
        {
            List<PassengerModel> passengersList = new List<PassengerModel>();
            try
            {
                List<Passenger> list = await _flightBA.GetPassengersAsync(flightName);
                foreach (Passenger item in list)
                {
                    PassengerModel passengerModel = new PassengerModel(item.PassengerName,item.PassengerAge);
                    passengersList.Add(passengerModel);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return passengersList;
        }
    }
}
