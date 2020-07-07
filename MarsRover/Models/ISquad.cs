using System.Collections.Generic;

namespace MarsRover.Models
{
    public interface ISquad
    {
        IList<IRover> Rovers { get; }

        IPlateau Plateau { get; }
    }
}