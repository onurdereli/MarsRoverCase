using MarsRover.Core.Helper.Directions.Abstract;
using MarsRover.Models.Enums;

namespace MarsRover.Core.Helper.Directions.Concrete
{
    public class SouthDirection : IDirection
    {
        public Direction TurnLeft()
        {
            return Direction.East;
        }

        public Direction TurnRight()
        {
            return Direction.West;
        }
    }
}