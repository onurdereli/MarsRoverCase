using MarsRover.Core.Helper.Directions.Abstract;
using MarsRover.Models.Enums;

namespace MarsRover.Core.Helper.Directions.Concrete
{
    public class WestDirection : IDirection
    {
        public Direction TurnLeft()
        {
            return Direction.South;
        }

        public Direction TurnRight()
        {
            return Direction.North;
        }
    }
}