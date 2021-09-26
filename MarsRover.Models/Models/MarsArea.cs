namespace MarsRover.Models.Models
{
    public class MarsArea
    {
        public int X { get; set; }

        public int Y { get; set; }
        
        public MarsArea(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}