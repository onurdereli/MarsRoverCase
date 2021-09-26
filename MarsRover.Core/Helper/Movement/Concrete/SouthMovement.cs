using System;
using MarsRover.Core.Helper.Movement.Base;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Movement.Concrete
{
    public class SouthMovement : BaseMovement
    {
        public override void CalculateRange(Rover rover)
        {
            if (rover.Y - 1 < 0)
            {
                throw new Exception("Out of Range");
            }
        }

        public override void MoveExecute(Rover rover)
        {
            rover.Y -= 1;
        }
    }
}
