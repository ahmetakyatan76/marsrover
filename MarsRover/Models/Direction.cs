using System;
using System.Collections.Generic;

namespace MarsRover.Models
{
    public enum DirectionKey
    {
        NORTH = 0, EAST = 1, SOUTH = 2, WEST = 3
    }

    public class Direction
    {
        public Direction(DirectionKey key, string title)
        {
            Key = key;
            Title = title;
        }

        public DirectionKey Key { get; set; }
        public string Title { get; set; }
    }

    public class Directions : List<Direction>
    {
        public Directions GetAll()
        {
            this.Add(new Direction(key: DirectionKey.NORTH, title: "N"));
            this.Add(new Direction(key: DirectionKey.EAST, title: "E"));
            this.Add(new Direction(key: DirectionKey.SOUTH, title: "S"));
            this.Add(new Direction(key: DirectionKey.WEST, title: "W"));

            return this;
        }
    }
}
