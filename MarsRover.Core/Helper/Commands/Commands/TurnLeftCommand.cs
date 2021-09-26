using MarsRover.Core.Helper.Commands.Base.Concrete;
using MarsRover.Core.Helper.Directions;
using MarsRover.Models.Enums;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Commands.Commands
{
    public class TurnLeftCommand : Command
    {
        protected override void DoExecute(Rover rover)
        {
            var direction = DirectionFactory.Instance.DirectionGenerator((Direction) rover.Direction);
            rover.Direction = (char) direction.TurnLeft();
        }
    }
}
