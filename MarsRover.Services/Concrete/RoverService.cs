using System.Collections.Generic;
using AutoMapper;
using MarsRover.Core.Helper.Extensions;
using MarsRover.Models.Models;
using MarsRover.Models.Requests;
using MarsRover.Services.Abstract;

namespace MarsRover.Services.Concrete
{
    public class RoverService : IRoverService
    {
        private readonly IMapper _mapper;
        private readonly IMarsAreaService _marsAreaService;
        private readonly ICommandService _commandService;

        public RoverService(IMapper mapper, IMarsAreaService marsAreaService, ICommandService commandService)
        {
            _mapper = mapper;
            _marsAreaService = marsAreaService;
            _commandService = commandService;
        }

        public List<Rover> GetRoverInformation(RoverInputRequest roverInputRequest)
        {
            var roverInput = _mapper.Map<RoverInput>(roverInputRequest);
            
            var marsArea = _marsAreaService.CreateMarsArea(roverInput.MarsArea);

            List<Rover> roverList = new();

            roverInput.RoverCommand.ForEach(roverCommand =>
            {
                var rover = RoverCommand(roverCommand, marsArea);
                roverList.Add(rover);
            });

            return roverList;
        }

        private Rover RoverCommand(RoverCommand roverCommand, MarsArea marsArea)
        {
            var movements = roverCommand.Command.GetMovementList();

            movements.ForEach(movement =>
            {
                var command = _commandService.Command(movement, marsArea);
                command.Execute(roverCommand.Rover);
            });

            return roverCommand.Rover;
        }
    }
}
