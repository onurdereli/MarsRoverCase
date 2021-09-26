using System;
using MarsRover.Core.Helper.Directions.Abstract;
using MarsRover.Core.Helper.Directions.Concrete;
using MarsRover.Models.Enums;

namespace MarsRover.Core.Helper.Directions
{
    public class DirectionFactory
    {
        private static DirectionFactory _instance;
        public static DirectionFactory Instance => _instance ??= new DirectionFactory();

        public IDirection DirectionGenerator(Direction direction)
        {
            return direction switch
            {
                Direction.North => new NorthDirection(),
                Direction.East => new EastDirection(),
                Direction.South => new SouthDirection(),
                Direction.West => new WestDirection(),
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
            };
        }
    }
}
