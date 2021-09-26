using MarsRover.Core.Helper.Commands.Base.Abstract;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Commands.Base.Concrete
{
    public abstract class Command: ICommand
    {
        protected abstract void DoExecute(Rover rover);

        public virtual void Execute(Rover rover)
        {
            DoExecute(rover);
        }
    }
}
