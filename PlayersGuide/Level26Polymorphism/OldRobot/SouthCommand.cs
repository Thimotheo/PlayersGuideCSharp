using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level26Polymorphism.OldRobot
{
    internal class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered) { robot.Y--; }
        }
    }
}
