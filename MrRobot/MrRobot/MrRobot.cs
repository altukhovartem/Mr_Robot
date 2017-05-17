using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class MrRobot
    {

        public Direction Direction { get; private set; } // текущее направление взгляда

        public int X { get; private set; } // текущая координата X

        public int Y { get; private set; } // текущая координата Y

        public MrRobot()
        {
            Direction = Direction.UP;
            X = 0;
            Y = 0;
        }

        public MrRobot(int x, int y)
        {

        }


        public void TurnLeft()
        {
            // повернуться на 90 градусов против часовой стрелки
            switch(Direction)
            {
                case Direction.UP: Direction = Direction.LEFT; break;
                case Direction.LEFT: Direction = Direction.DOWN; break;
                case Direction.DOWN: Direction = Direction.RIGHT; break;
                case Direction.RIGHT: Direction = Direction.UP; break;
            }
        }

        public void TurnRight()
        {
            // повернуться на 90 градусов по часовой стрелке
            switch (Direction)
            {
                case Direction.UP: Direction = Direction.RIGHT; break;
                case Direction.RIGHT: Direction = Direction.DOWN; break;
                case Direction.DOWN: Direction = Direction.LEFT; break;
                case Direction.LEFT: Direction = Direction.UP; break;
            }
        }

        public void StepForward()
        {
            // шаг в направлении взгляда
            // за один шаг робот изменяет одну свою координату на единицу
            switch (Direction)
            {
                case Direction.UP: Y++; break;
                case Direction.RIGHT: X++; break;
                case Direction.DOWN: Y--; break;
                case Direction.LEFT: X--; break;
            }
        }

        
    }

    public enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

}
