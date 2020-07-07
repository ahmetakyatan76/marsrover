using MarsRover.Models;

namespace MarsRover.Services
{
    public interface IRoverService
    {
        Rover CreateRover(string coordinatesAndRotation, ISquad squad);
        void TransferRover(Rover rover, string movements);
    }
}