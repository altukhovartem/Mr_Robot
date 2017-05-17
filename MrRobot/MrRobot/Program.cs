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
            robot.Move(2, 3);
            robot.CurrentLocation();
            robot.CurrentDirection();
            robot.Move(5, 2);
            robot.CurrentLocation();
            robot.CurrentDirection();
            robot.Move(-5, 0);
            robot.CurrentLocation();
            robot.CurrentDirection();
            robot.Move(-5, 0);
            robot.CurrentLocation();
            robot.CurrentDirection();
        }

        public static void Move(this MrRobot robot, int newX, int newY)
        {
            int currentX = robot.X;
            int currentY = robot.Y;
            if (newX > currentX)
            {
                while (robot.Direction != Direction.RIGHT)
                {
                    if (robot.Direction == Direction.UP)
                        robot.TurnRight();
                    else if (robot.Direction == Direction.DOWN)
                        robot.TurnLeft();
                    else
                        robot.TurnRight();
                }
                for (int i = 0; i < newX - currentX; i++)
                {
                    robot.StepForward();
                }
            }
            else if (newX < currentX)
            {
                while (robot.Direction != Direction.LEFT)
                {
                    if (robot.Direction == Direction.UP)
                        robot.TurnLeft();
                    else if (robot.Direction == Direction.DOWN)
                        robot.TurnRight();
                    else
                        robot.TurnLeft();
                }
                for (int i = 0; i < currentX - newX; i++)
                {
                    robot.StepForward();
                }
            }
            if (newY > currentY)
            {
                while (robot.Direction != Direction.UP)
                {
                    if (robot.Direction == Direction.LEFT)
                        robot.TurnRight();
                    else if (robot.Direction == Direction.RIGHT)
                        robot.TurnLeft();
                    else
                        robot.TurnRight();
                }
                for (int i = 0; i < newY - currentY; i++)
                {
                    robot.StepForward();
                }
            }
            else if (newY < currentY)
            {
                while (robot.Direction != Direction.DOWN)
                {
                    if (robot.Direction == Direction.RIGHT)
                        robot.TurnRight();
                    else if (robot.Direction == Direction.LEFT)
                        robot.TurnLeft();
                    else
                        robot.TurnLeft();
                }
                for (int i = 0; i < currentY - newY; i++)
                {
                    robot.StepForward();
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
