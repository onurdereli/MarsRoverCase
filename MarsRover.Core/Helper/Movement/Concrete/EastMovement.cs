using System;
using MarsRover.Core.Helper.Movement.Base;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Movement.Concrete
{
    public class EastMovement: BaseMovement
    {
        private readonly MarsArea _marsArea;

        public EastMovement(MarsArea marsArea)
        {
            _marsArea = marsArea;
        }

        public override void CalculateRange(Rover rover)
        {
            if (rover.X + 1 > _marsArea.X)
            {
                throw new Exception("Out of Range");
            }
        }

        public override void MoveExecute(Rover rover)
        {
            rover.X += 1;
        }
    }
}
