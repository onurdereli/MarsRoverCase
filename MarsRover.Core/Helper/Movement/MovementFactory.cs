using System;
using MarsRover.Core.Helper.Movement.Abstract;
using MarsRover.Core.Helper.Movement.Concrete;
using MarsRover.Models.Enums;
using MarsRover.Models.Models;

namespace MarsRover.Core.Helper.Movement
{
    public class MovementFactory
    {
        private static MovementFactory _instance;
        public static MovementFactory Instance => _instance ??= new MovementFactory();

        public IBaseMovement MovementGenerator(Direction direction, MarsArea marsArea)
        {
            return direction switch
            {
                Direction.North => new NorthMovement(marsArea),
                Direction.East => new EastMovement(marsArea),
                Direction.South => new SouthMovement(),
                Direction.West => new WestMovement(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
