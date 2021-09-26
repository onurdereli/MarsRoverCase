using System;
using MarsRover.Core.Helper.Commands.Commands;
using MarsRover.Models.Enums;
using MarsRover.Models.Models;
using MarsRover.Services.Abstract;
using MarsRover.Services.Concrete;
using Xunit;

namespace MarsRover.Test
{
    public class CommandTest
    {
        private readonly ICommandService _commandService;

        public CommandTest()
        {
            _commandService = new CommandService();
        }
        
        [Theory]
        [InlineData(5, 5, 'L', 1, 3, 'S')]
        public void GetRover_TurnLeftWhenSouth_ReturnEastDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnLeftCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.East, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'L', 1, 3, 'E')]
        public void GetRover_TurnLeftWhenEast_ReturnNorthDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnLeftCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.North, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'L', 1, 3, 'W')]
        public void GetRover_TurnLeftWhenWest_ReturnSouthDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnLeftCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.South, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'L', 1, 3, 'N')]
        public void GetRover_TurnLeftWhenNorth_ReturnWestDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnLeftCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.West, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'R', 1, 3, 'S')]
        public void GetRover_TurnRightWhenSouth_ReturnWestDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnRightCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.West, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'R', 1, 3, 'E')]
        public void GetRover_TurnRightWhenEast_ReturnSouthDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnRightCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.South, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'R', 1, 3, 'W')]
        public void GetRover_TurnRightWhenWest_ReturnNorthDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnRightCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.North, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'R', 1, 3, 'N')]
        public void GetRover_TurnRightWhenNorth_ReturnDirection(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<TurnRightCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(Direction.East, (Direction) rover.Direction);
        }

        [Theory]
        [InlineData(5, 5, 'M', 1, 3, 'S')]
        public void GetRover_ForwardMoveWhenSouth_ReturnDecreasedByOneInYaxis(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<ForwardMoveCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(rover.Y , roverY - 1);
        }

        [Theory]
        [InlineData(5, 5, 'M', 1, 3, 'E')]
        public void GetRover_ForwardMoveWhenEast_ReturnDecreasedByOneInYaxis(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<ForwardMoveCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(rover.X , roverX + 1);
        }

        [Theory]
        [InlineData(5, 5, 'M', 1, 3, 'N')]
        public void GetRover_ForwardMoveWhenNorth_ReturnDecreasedByOneInYaxis(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<ForwardMoveCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(rover.Y , roverY + 1);
        }

        [Theory]
        [InlineData(5, 5, 'M', 1, 3, 'W')]
        public void GetRover_ForwardMoveWhenWest_ReturnDecreasedByOneInYaxis(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<ForwardMoveCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            command.Execute(rover);

            Assert.Equal(rover.X , roverX - 1);
        }

        [Theory]
        [InlineData(5, 5, 'M', 0, 3, 'W')]
        public void GetRover_ForwardMoveWhenWest_ReturnException(int marsAreaX, int marsAreaY, char movement, int roverX,int roverY, char roverDirection)
        {
            var command = _commandService.Command((Movement) movement, new MarsArea(marsAreaX, marsAreaY));
            
            Assert.IsType<ForwardMoveCommand>(command);

            var rover = new Rover { Direction = roverDirection, X = roverX, Y = roverY };
            
            Assert.Throws<Exception>(() => command.Execute(rover));
        }

        [Theory]
        [InlineData(5, 5, 'E')]
        public void GetCommand_whenDifferentMoveIsEntered_ReturnArgumentOutOfRangeException(int marsAreaX, int marsAreaY, char movement)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _commandService.Command((Movement)movement, new MarsArea(marsAreaX, marsAreaY)));
        }
    }
}
