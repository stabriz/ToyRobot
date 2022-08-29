using ToyRobot.Enums;

namespace ToyRobot
{
    public class Robot
    {
        public Position Position { get; private set; }
        public Direction Direction { get; private set; }

        public void Place(Position position, Direction direction)
        {
            Position = position;
            Direction = direction;
        }

        public void Place(Position position)
        {
            Position = position;
        }


        public void Move()
        {
            Position = TryMove();
        }

        public Position TryMove()
        {
            Position nextPosition = new Position(Position);
            switch (Direction)
            {
                case Direction.NORTH:
                    nextPosition.Y += 1;
                    break;
                case Direction.SOUTH:
                    nextPosition.Y -= 1;
                    break;
                case Direction.EAST:
                    nextPosition.X += 1;
                    break;
                case Direction.WEST:
                    nextPosition.X -= 1;
                    break;
            }
            return nextPosition;
        }

        public void TurnRight()
        {
            Direction = (Direction)(((int)Direction + 1) % 4);
        }

        public void TurnLeft()
        {
            Direction = (Direction == Direction.NORTH) ? Direction.WEST : (Direction)((int)Direction - 1);
        }

        public string Report()
        {
            return $"Output: {Position.X},{Position.Y},{Direction}";
        }



    }
}
