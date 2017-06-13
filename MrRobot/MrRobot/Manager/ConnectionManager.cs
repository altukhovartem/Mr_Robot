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
            int attemptToConnect = 0;
            Connection currentConnection = new Connection(robot);
            while (attemptToConnect < 3)
            {
                attemptToConnect++;
                return new Connection(robot);
            }
            throw new RobotConnectionException("Failed to connect to the robot");
        }
    }
}
