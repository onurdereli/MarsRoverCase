using MarsRover.Core.Helper.Commands;
using MarsRover.Core.Helper.Commands.Base.Abstract;
using MarsRover.Models.Enums;
using MarsRover.Models.Models;
using MarsRover.Services.Abstract;

namespace MarsRover.Services.Concrete
{
    public class CommandService: ICommandService
    {
        public ICommand Command(Movement movement, MarsArea marsArea)
        {
            return CommandFactory.Instance.CommandGenerator(movement, marsArea);
        }
    }
}
