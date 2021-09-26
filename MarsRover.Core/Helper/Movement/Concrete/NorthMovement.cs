using System;
using MarsRover.Core.Helper.Movement.Base;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Movement.Concrete
{
    public class NorthMovement : BaseMovement
    {
        private readonly MarsArea _marsArea;

        public NorthMovement(MarsArea marsArea)
        {
            _marsArea = marsArea;
        }

        public override void CalculateRange(Rover rover)
        {
            if (rover.Y + 1 > _marsArea.Y)
            {
                throw new Exception("Out of Range");
            }
        }

        public override void MoveExecute(Rover rover)
        {
            rover.Y += 1;
        }
    }
}