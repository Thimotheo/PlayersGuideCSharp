using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level27Interfaces
{
    internal class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) { robot.Y++; }
        }
    }
}
