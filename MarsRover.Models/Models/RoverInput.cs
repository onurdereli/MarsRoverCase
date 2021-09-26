using System.Collections.Generic;

namespace MarsRover.Models.Models
{
    public class RoverInput
    {
        public MarsArea MarsArea { get; set; }

        public List<RoverCommand> RoverCommand { get; set; }
    }
}
