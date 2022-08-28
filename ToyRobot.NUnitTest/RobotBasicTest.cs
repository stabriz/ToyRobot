using NUnit.Framework;
using ToyRobot.Interface;
using ToyRobot.Enums;

namespace ToyRobot.NUnitTest
{
    public class RobotBasicTest
    {
        IRobot robot; 

        [SetUp]
        public void Setup()
        {
            robot = new Robot();
            Position position = new Position(1, 2);
            robot.Place(position, Direction.East);
        }

        [Test]
        public void TestPlace()
        {
            Assert.AreEqual(robot.Report(), @"Output: 1,2,EAST");
        }

        [Test]
        public void TestMoveFacingEast()
        {
            robot.Move();
            Assert.AreEqual(robot.Report(), @"Output: 1,3,EAST");
        }

        [Test]
        public void TestMoveTwiceFacingEast()
        {
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Report(), @"Output: 1,4,EAST");
        }

        [Test]
        public void TestMoveTwiceFacingNorth()
        {

        }

        [Test]
        public void TestTurnLeft()
        {
            robot.TurnLeft();
            Assert.AreEqual(robot.Report(), @"Output: 1,2,NORTH");
        }
        [Test]
        public void TestTurnRight()
        {
            robot.TurnRight();
            Assert.AreEqual(robot.Report(), @"Output: 1,2,SOUTH");
        }
        [Test]
        public void TestTurnRightFourTime()
        {
            robot.TurnRight();
            robot.TurnRight();
            robot.TurnRight();
            robot.TurnRight();
            Assert.AreEqual(robot.Report(), @"Output: 1,2,EAST");
        }
        [Test]
        public void TestTurnLeftFiveTime()
        {
            robot.TurnLeft();
            robot.TurnLeft();
            robot.TurnLeft();
            robot.TurnLeft();
            robot.TurnLeft();
            Assert.AreEqual(robot.Report(), @"Output: 1,2,NORTH");
        }
    }
}