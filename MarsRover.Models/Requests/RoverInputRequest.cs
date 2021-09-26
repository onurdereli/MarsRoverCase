using System.Collections.Generic;

namespace MarsRover.Models.Requests
{
    public class RoverInputRequest
    {
        public MarsAreaRequest MarsArea { get; set; }

        public List<RoverCommandRequest> RoverCommand { get; set; }
    }
}
