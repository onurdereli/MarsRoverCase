using MarsRover.Core.Helper.Movement.Abstract;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Movement.Base
{
    public abstract class BaseMovement : IBaseMovement
    {
        public abstract void CalculateRange(Rover rover);

        public abstract void MoveExecute(Rover rover);

        public virtual void Move(Rover rover)
        {
            CalculateRange(rover);
            MoveExecute(rover);
        }
    }
}
