using System.Collections.Generic;
using MarsRover.Models.Models;
using MarsRover.Models.Requests;

namespace MarsRover.Services.Abstract
{
    public interface IRoverService
    {
        List<Rover> GetRoverInformation(RoverInputRequest roverInputRequest);

    }
}
