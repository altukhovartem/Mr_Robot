using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    public class ConnectionManager : RobotConnectionManager
    {
        private MrRobot robot = null;

        public ConnectionManager(MrRobot robot)
        {
            this.robot = robot;
        }

        public RobotConnection GetConnection()
        {
            if (new Random().Next(0, 20) % 3 == 1)
            {
                throw new RobotConnectionException("Robot is busy. Please, do not disturb Robot");
            }
            else
            {
                return new Connection(robot);
            }
        }
    }
}
