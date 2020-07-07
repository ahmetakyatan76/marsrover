using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Plateau : IPlateau
    {
        public Plateau(int maxX, int maxY)
        {
            this.MaxX = maxX;
            this.MaxY = maxY;
            this._squads = new Lazy<List<ISquad>>();
        }

        public int MaxX { get; }

        public int MaxY { get; }

        private Lazy<List<ISquad>> _squads { get; set; }
        public IList<ISquad> Squads => _squads.Value;
    }
}
