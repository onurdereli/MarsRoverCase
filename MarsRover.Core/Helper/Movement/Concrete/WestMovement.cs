using System;
using MarsRover.Core.Helper.Movement.Base;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Movement.Concrete
{
    public class WestMovement : BaseMovement
    {
        public override void CalculateRange(Rover rover)
        {
            if (rover.X - 1 < 0)
            {
                throw new Exception("Out of Range");
            }
        }

        public override void MoveExecute(Rover rover)
        {
            rover.X -= 1;
        }
    }
}
