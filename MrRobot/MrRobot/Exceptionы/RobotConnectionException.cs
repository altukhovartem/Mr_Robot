using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    public class RobotConnectionException : Exception
    {
        public RobotConnectionException(String message)
            : base(message) { }

        public RobotConnectionException(String message, Exception cause)
        : base(message, cause) { }

    }
}