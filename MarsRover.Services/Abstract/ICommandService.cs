using MarsRover.Core.Helper.Commands.Base.Abstract;
using MarsRover.Models.Enums;
using MarsRover.Models.Models;

namespace MarsRover.Services.Abstract
{
    public interface ICommandService
    {
        ICommand Command(Movement movement, MarsArea marsArea);
    }
}
