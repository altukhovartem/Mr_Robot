using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    static class Program
    {
        static void Main(string[] args)
        {
            MrRobot robot = new MrRobot();
            ConnectionManager conManager = new ConnectionManager(robot);
            moveRobot(conManager, 2, 3);
            CurrentLocation(robot);
           
        }

        public static void moveRobot(RobotConnectionManager robotConnectionManager, int toX, int toY)
        {
            int attempt = 0;
            while (attempt < 3)
            {
                attempt++;
                RobotConnection currentConnection = null;
                try
                {
                    currentConnection = robotConnectionManager.GetConnection();
                    if (currentConnection == null)
                    {
                        throw new RobotConnectionException("Connection has been failed");
                    }
                    else
                    {
                        currentConnection.MoveRobotTo(toX, toY);
                        break;
                    }
                }
                catch(RobotConnectionException e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
                finally
                {
                    if (currentConnection != null)
                    {
                        currentConnection.Dispose();
                    }
                }
            }
        }

        public static void moveRobotNewVersion(RobotConnectionManager robotConnectionManager, int toX, int toY)
        {
            int attempt = 0;
            while (attempt < 3)
            {
                attempt++;
                RobotConnection currentConnection = null;
                try
                {
                    using (currentConnection = robotConnectionManager.GetConnection())
                    {
                        try
                        {
                            currentConnection.MoveRobotTo(toX, toY);
                            break;
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Error: {0}", e.Message);
                        }
                    }
                }
                catch (RobotConnectionException e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
        }


        public static void CurrentLocation(this MrRobot robot)
        {
            Console.WriteLine("X = {0}\nY = {1}", robot.X, robot.Y);
        }

        public static void CurrentDirection(this MrRobot robot)
        {
            Console.WriteLine("Current Direction: {0}", robot.Direction);
        }

    }
}
