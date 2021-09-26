namespace MarsRover.Models.Requests
{
    public class RoverCommandRequest
    {
        public RoverRequest Rover { get; set; }

        public string Command { get; set; }
    }
}
