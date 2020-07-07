using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class RoverSquad : ISquad
    {
        public RoverSquad(IPlateau plateau)
        {
            this.Plateau = plateau;
            this._rovers = new Lazy<List<IRover>>();
        }

        public IPlateau Plateau { get; private set; }

        private Lazy<List<IRover>> _rovers { get; set; }
        public IList<IRover> Rovers => _rovers.Value;
    }
}
