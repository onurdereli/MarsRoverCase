using Microsoft.AspNetCore.Mvc;
using MarsRover.Models.Requests;
using MarsRover.Services.Abstract;

namespace MarsRover.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoversController : ControllerBase
    {
        private readonly IRoverService _roverService;

        public RoversController(IRoverService roverService)
        {
            _roverService = roverService;
        }

        [HttpPost]
        public IActionResult GetRoversInformation(RoverInputRequest roverInputRequest)
        {
            return Ok(_roverService.GetRoverInformation(roverInputRequest));
        }
    }
}
