using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Services
{
    public class RoverService : IRoverService
    {
        public virtual Rover CreateRover(string coordinatesAndRotation, ISquad squad)
        {
            var input = coordinatesAndRotation.Split(' ');
            if (input.Length < 3)
                throw new ArgumentException("Coordinates And/Or direction not set properly");

            int x;
            if (!int.TryParse(input[0], out x))
                throw new ArgumentException("X coordinate not set properly");

            int y;
            if (!int.TryParse(input[1], out y))
                throw new ArgumentException("Y coordinate not set properly");


            var directionTitle = input[2];
            var direction = new Directions().GetAll().FirstOrDefault(w => w.Title == directionTitle);
            if (direction == null)
                throw new ArgumentException("Direction not set properly");

            return new Rover(x, y, direction, squad);

        }

        public virtual void TransferRover(Rover rover, string stepAndRotations)
        {
            foreach (var movement in stepAndRotations)
            {
                switch (movement)
                {
                    case 'M':
                        MakeStep(rover); break;
                    case 'L':
                        Rotate(rover, Rotation.LEFT); break;
                    case 'R':
                        Rotate(rover, Rotation.RIGHT); break;

                    default:
                        throw new ArgumentException();
                }
            }
        }

        protected virtual void MakeStep(Rover rover)
        {
            switch (rover.Direction.Key)
            {
                case DirectionKey.NORTH:
                    rover.Y += 1;
                    break;

                case DirectionKey.EAST:
                    rover.X += 1;
                    break;

                case DirectionKey.SOUTH:
                    rover.Y -= 1;
                    break;

                case DirectionKey.WEST:
                    rover.X -= 1;
                    break;
            }
        }

        protected virtual void Rotate(Rover rover, string rotation)
        {
            int roverFacing = (int)rover.Direction.Key;

            switch (rotation)
            {
                case Rotation.LEFT:
                    if (roverFacing == 0)
                    {
                        roverFacing = 4;
                    }
                    rover.Direction.Key = (DirectionKey)(--roverFacing);
                    break;

                case Rotation.RIGHT:
                    rover.Direction.Key = (DirectionKey)((++roverFacing) % 4);
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    }
}
