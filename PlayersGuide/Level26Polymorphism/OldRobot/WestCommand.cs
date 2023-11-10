using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level26Polymorphism.OldRobot
{
    internal class WestCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered) { robot.X--; }
        }
    }
}
