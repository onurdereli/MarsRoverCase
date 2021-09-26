using System.Collections.Generic;
using MarsRover.API.Controllers;
using MarsRover.Models.Models;
using MarsRover.Models.Requests;
using MarsRover.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace MarsRover.Test
{
    public class RoverTest
    {
        private readonly Mock<IRoverService> _mockRepo;
        
        private readonly RoversController _controller;

        private readonly RoverInputRequest _roverInputRequest;

        public RoverTest()
        {
            _mockRepo = new();
            _controller = new(_mockRepo.Object);
            _roverInputRequest = SetTestRoverInput();
        }

        [Fact]
        public void GetRoversInformation_RoverInputIsValid_ReturnRoverRequest()
        {
            List<Rover> roverRequestList = GetRoverRequestList();

            _mockRepo.Setup(x => x.GetRoverInformation(_roverInputRequest)).Returns(roverRequestList);

            var result = _controller.GetRoversInformation(_roverInputRequest);

            var okResult = Assert.IsType<OkObjectResult>(result);

            var returnRovers = Assert.IsAssignableFrom<List<Rover>>(okResult.Value);

            Assert.Equal(2, returnRovers.Count);
        }
        
        private static List<Rover> GetRoverRequestList()
        {
            return new()
            {
                new()
                {
                    Direction = 'N',
                    X = 1,
                    Y = 3
                },
                new()
                {
                    Direction = 'E',
                    X = 5,
                    Y = 1
                }
            };
        }

        private RoverInputRequest SetTestRoverInput()
        {
            return new RoverInputRequest()
            {
                MarsArea = new MarsAreaRequest()
                {
                    X = 5,
                    Y = 5
                },
                RoverCommand = new List<RoverCommandRequest>()
                {
                    new()
                    {
                        Command = "LMLMLMLMM",
                        Rover = new RoverRequest()
                        {
                            X= 1,
                            Y=2,
                            Direction = 'N'
                        }
                    },
                    new()
                    {
                        Command = "MMRMMRMRRM",
                        Rover = new RoverRequest()
                        {
                            X= 3,
                            Y= 3,
                            Direction = 'E'
                        }
                    }
                }
            };
        }
    }
}
