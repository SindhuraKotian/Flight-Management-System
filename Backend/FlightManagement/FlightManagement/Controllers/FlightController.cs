using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCodingChallenge.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalCodingChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly ManagerModel _managerModel;

        public FlightController(ManagerModel managerModel)
        {
            _managerModel = managerModel;
        }

        [HttpPost("AddPassenger")]
        public async Task<ActionResult<string>> AddPassengerAsync([FromBody] PassengerModel passengerModel)
        {
            string status = "";
            try
            {
                status = await _managerModel.AddPassengerAsync(passengerModel);
            }
            catch (Exception e)
            {
                return NotFound(new
                {
                    errorMessage = e.Message
                });
            }
            return Ok(new
            {
                addMessage = passengerModel.PassengerName + " " + status
            });

        }

        [HttpPost("UpdatePassenger")]
        public async Task<ActionResult<string>> UpdatePassenger(int passengerId, int flightId)
        {
            string status = "";
            try
            {

                status = await _managerModel.UpdatePassengerAsync(passengerId,flightId);
            }
            catch (Exception e)
            {
                return NotFound(new
                {
                    errorMessage = e.Message
                });
            }
            return Ok(status);

        }

        //[HttpGet("GetFlight/{flightName}")]
        [HttpGet("GetFlight")]
        public async Task<ActionResult<List<FlightModel>>> GetFlights()
        {
            List<FlightModel> flightModelList = null;
            try
            {
                flightModelList = await _managerModel.GetFlights();
            }
            catch (Exception e)
            {
                return NotFound(new
                {
                    errorMessage = e.Message
                });
            }
            return Ok(new
            {
                flightModelList
            });
        }

        [HttpGet("GetPassengers/{flightName}")]
        public async Task<ActionResult<List<PassengerModel>>> GetPassengers(string flightName)
        {
            List<PassengerModel> passengerModelList = new List<PassengerModel>();
            try
            {
                passengerModelList = await _managerModel.GetPassengersAsync(flightName);
            }
            catch (Exception e)
            {
                return NotFound(new
                {
                    errorMessage = e.Message
                });
            }
            return Ok(new
            {
                passengerModelList
            });
        }
    }
}
