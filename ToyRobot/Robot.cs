using System;
using ToyRobot.Enums;
using ToyRobot.Interface;
namespace ToyRobot
{
    public class Robot : IRobot
    {
        private Position _position;
        private Direction _direction;

        public void Place(Position position, Direction direction)
        {
            _position = position;  
            _direction = direction;
        }

        public void Place(Position position)
        {
            _position = position;
        }

        public void Move()
        {            
            switch (_direction)
            {
                case Direction.North: 
                    _position.X +=1; 
                    break;
                case Direction.South:
                    _position.X -=1; 
                    break;
                case Direction.East:
                    _position.Y +=1 ;
                    break;
                case Direction.West:
                    _position.Y -= 1;
                    break;
            }

        }

        public void TurnRight()
        {
            _direction = (Direction)(((int)_direction + 1) % 4);
        }

        public void TurnLeft()
        {
            _direction = (_direction == Direction.North) ? Direction.East : (Direction)((int)_direction - 1);
        }

        public string Report()
        {
            return $"Output: {_position.X},{_position.Y},{_direction.ToString().ToUpper()}";
        }



    }
}
