using MarsRover.Models.Enums;

namespace MarsRover.Core.Helper.Directions.Abstract
{
    public interface IDirection
    {
        Direction TurnLeft();
        Direction TurnRight();
    }
}