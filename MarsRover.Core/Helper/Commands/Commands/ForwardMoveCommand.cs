using MarsRover.Core.Helper.Commands.Base.Concrete;
using MarsRover.Core.Helper.Movement;
using MarsRover.Models.Enums;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Commands.Commands
{
    public class ForwardMoveCommand : Command
    {
        private readonly MarsArea _marsArea;
        public ForwardMoveCommand(MarsArea marsArea)
        {
            _marsArea = marsArea;
        }

        protected override void DoExecute(Rover rover)
        {
            var movement = MovementFactory.Instance.MovementGenerator((Direction) rover.Direction, _marsArea);
            movement.Move(rover);
        }
    }
}
