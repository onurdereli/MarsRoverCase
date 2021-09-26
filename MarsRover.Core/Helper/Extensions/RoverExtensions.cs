using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Core.Helper.Extensions
{
    public static class RoverExtensions
    {
        public static List<Models.Enums.Movement> GetMovementList(this string movements)
        {
            return movements.ToCharArray().Select(movement => (Models.Enums.Movement) movement).ToList();
        }
    }
}
