using FluentValidation;
using MarsRover.Models.Requests;

namespace MarsRover.Services.ValidationRules.FluentValidation
{
    public class RoverInputRequestValidator : AbstractValidator<RoverInputRequest>
    {
        public RoverInputRequestValidator()
        {
            RuleFor(r => r.MarsArea).NotEmpty();
            RuleFor(r => r.MarsArea.X).GreaterThan(0).NotEmpty();
            RuleFor(r => r.MarsArea.Y).GreaterThan(0).NotEmpty();
            RuleForEach(r => r.RoverCommand)
                .ChildRules(command =>
                {
                    command.RuleFor(x => x.Rover.Direction).NotEmpty();
                    command.RuleFor(x => x.Rover.X).GreaterThanOrEqualTo(0).NotEmpty();
                    command.RuleFor(x => x.Rover.Y).GreaterThanOrEqualTo(0).NotEmpty();
                    command.RuleFor(x => x.Command).NotEmpty();
                })
                .NotEmpty();
        }
    }
}
