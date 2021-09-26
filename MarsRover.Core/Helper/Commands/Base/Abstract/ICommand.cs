using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Commands.Base.Abstract
{
    public interface ICommand
    {
        public void Execute(Rover rover);
    }
}
