namespace MarsRover.Models
{
    public interface IRover
    {
        int X { get; }
        int Y { get; }
        Direction Direction { get;  }
        ISquad Squad { get; }
    }
}