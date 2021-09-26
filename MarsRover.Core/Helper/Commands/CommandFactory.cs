using System;
using MarsRover.Core.Helper.Commands.Base.Abstract;
using MarsRover.Core.Helper.Commands.Commands;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Commands
{
    public class CommandFactory
    {
        private static CommandFactory _instance;
        public static CommandFactory Instance => _instance ??= new CommandFactory();

        public ICommand CommandGenerator(Models.Enums.Movement movement, MarsArea marsArea)
        {
            return movement switch
            {
                Models.Enums.Movement.Left => new TurnLeftCommand(),
                Models.Enums.Movement.Right => new TurnRightCommand(),
                Models.Enums.Movement.Move => new ForwardMoveCommand(marsArea),
                _ => throw new ArgumentOutOfRangeException(nameof(movement), movement, null)
            };
        }
    }
}
