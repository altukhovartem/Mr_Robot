using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    public interface RobotConnection : IDisposable
    {
        void MoveRobotTo(int x, int y);
        void Dispose();
    }

}
