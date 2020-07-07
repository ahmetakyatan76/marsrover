using MarsRover.Models;
using MarsRover.Services;
using System;

namespace AAky
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateau = new Plateau(5,5);
            var roverSquad = new RoverSquad(plateau);
            plateau.Squads.Add(roverSquad);

            var roverService = new RoverService();
            var rover1 = roverService.CreateRover("1 2 N", roverSquad);
            roverService.TransferRover(rover1, "LMLMLMLMM");
            roverSquad.Rovers.Add(rover1);

            var rover2 = roverService.CreateRover("3 3 E", roverSquad);
            roverService.TransferRover(rover2, "MMRMMRMRRM");
            roverSquad.Rovers.Add(rover2);

            foreach (var item in roverSquad.Rovers)
            {
                Console.WriteLine($"{item.X} {item.Y} {item.Direction.Title}");
            }

            Console.ReadLine();
        }
    }
}
