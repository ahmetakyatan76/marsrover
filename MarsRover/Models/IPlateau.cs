using System.Collections.Generic;

namespace MarsRover.Models
{
    public interface IPlateau
    {
        /// <summary>
        /// Max X Coordinate 
        /// </summary>
        int MaxX { get; }

        /// <summary>
        /// Max Y Coordinate 
        /// </summary>
        int MaxY { get; }

        /// <summary>
        /// Squads appended to Floor 
        /// </summary>
        IList<ISquad> Squads { get; }
    }
}