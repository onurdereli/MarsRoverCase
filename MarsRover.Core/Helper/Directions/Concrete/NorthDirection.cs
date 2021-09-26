using MarsRover.Core.Helper.Directions.Abstract;
using MarsRover.Models.Enums;

namespace MarsRover.Core.Helper.Directions.Concrete
{
    public class NorthDirection : IDirection
    {
        public Direction TurnLeft()
        {
            return Direction.West;
        }

        public Direction TurnRight()
        {
            return Direction.East;
        }
    }
}