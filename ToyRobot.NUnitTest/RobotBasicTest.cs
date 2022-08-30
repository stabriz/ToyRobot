using NUnit.Framework;
using ToyRobot.Enums;

namespace ToyRobot.NUnitTest
{
    public class RobotBasicTest
    {
        Robot _robot;

        [SetUp]
        public void Setup()
        {
            _robot = new Robot();
            Position position = new Position(0, 0);
            _robot.Place(position, Direction.NORTH);
        }

        [Test]

        public void TestPlace()
        {
            Assert.AreEqual(_robot.Report(), @"Output: 0,0,NORTH");
        }

        [Test]
        public void TestMoveFacingNorth()
        {
            _robot.Move();
            Assert.AreEqual(_robot.Report(), @"Output: 0,1,NORTH");
        }

        [Test]
        public void TestMoveTwiceFacingNORTH()
        {
            _robot.Move();
            _robot.Move();
            Assert.AreEqual(_robot.Report(), @"Output: 0,2,NORTH");
        }



        [Test]
        public void TestTurnLeft()
        {
            _robot.TurnLeft();
            Assert.AreEqual(_robot.Report(), @"Output: 0,0,WEST");
        }
        

        [Test]
        public void TestTurnRight()
        {
            _robot.TurnRight();
            Assert.AreEqual(_robot.Report(), @"Output: 0,0,EAST");
        }
        [Test]
        public void TestTurnRightFourTime()
        {
            _robot.TurnRight();
            _robot.TurnRight();
            _robot.TurnRight();
            _robot.TurnRight();
            Assert.AreEqual(_robot.Report(), @"Output: 0,0,NORTH");
        }
        [Test]
        public void TestTurnLeftFiveTime()
        {
            _robot.TurnLeft();
            _robot.TurnLeft();
            _robot.TurnLeft();
            _robot.TurnLeft();
            _robot.TurnLeft();
            Assert.AreEqual(_robot.Report(), @"Output: 0,0,WEST");
        }
    }
}