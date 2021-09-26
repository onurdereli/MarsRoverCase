using MarsRover.Models.Models;
using MarsRover.Services.Abstract;

namespace MarsRover.Services.Concrete
{
    public class MarsAreaService : IMarsAreaService
    {
        public MarsArea CreateMarsArea(MarsArea marsArea) => new(marsArea.X, marsArea.Y);
    }
}
