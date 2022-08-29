﻿namespace ToyRobot
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Position(Position position)
        {
            this.X = position.X;
            this.Y = position.Y;
        }
    }
}
