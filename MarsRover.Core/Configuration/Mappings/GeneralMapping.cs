using AutoMapper;
using MarsRover.Models.Models;
using MarsRover.Models.Requests;

namespace MarsRover.Core.Configuration.Mappings
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<RoverInputRequest, RoverInput>()
                .ReverseMap();
            CreateMap<MarsAreaRequest, MarsArea>()
                .ReverseMap();
            CreateMap<Rover, RoverRequest>()
                .ReverseMap();
            CreateMap<RoverCommandRequest, RoverCommand>()
                .ReverseMap();
        }
    }
}
