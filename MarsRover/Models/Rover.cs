using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Rover : IRover
    {
        public Rover(int x, int y, Direction direction, ISquad squad)
        {
            X = x;
            Y = y;
            Direction = direction;
            Squad = squad;

            if (!IsInPlateauCoordinates)
            {
                throw new ArgumentException("Current coordinates are in the plateau cooridnates");
            }
        }

        /// <summary>
        /// Current X coordinate 
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Current Y coordinate 
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Facing Direction
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Chech whether the current coordinates are in the plateau cooridnates
        /// </summary>
        public bool IsInPlateauCoordinates
        {
            get
            {
                return (this.X >= 0) && (this.X < Squad.Plateau.MaxX) &&
                    (this.Y >= 0) && (this.Y < Squad.Plateau.MaxY);
            }
        }


        public virtual ISquad Squad { get; private set; }
    }

}
