using MarsRover.Core.Helper.Directions.Abstract;
using MarsRover.Models.Enums;

namespace MarsRover.Core.Helper.Directions.Concrete
{
    public class EastDirection : IDirection
    {
        public Direction TurnLeft()
        {
            return Direction.North;
        }

        public Direction TurnRight()
        {
            return Direction.South;
        }
    }
}