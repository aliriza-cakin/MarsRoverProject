using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRoverProject.RoverCommands;

namespace MarsRoverProject
{
    public class Robots
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Directions Direction { get; set; }
        public string Commands { get; set; }
        public string NewPosition { get; set; }
        public bool IsSuccses { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}
