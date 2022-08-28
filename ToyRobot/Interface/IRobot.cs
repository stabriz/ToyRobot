using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Enums;

namespace ToyRobot.Interface
{
    public interface IRobot
    {
        void Place(Position position, Direction direction);
        void Move();
        void TurnLeft();
        void TurnRight();
        string Report();
    }
}
