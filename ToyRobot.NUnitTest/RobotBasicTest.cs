using NUnit.Framework;
using ToyRobot.Enums;

namespace ToyRobot.NUnitTest
{
    public class RobotBasicTest
    {
        Robot robot;

        [SetUp]
        public void Setup()
        {
            robot = new Robot();
            Position position = new Position(0, 0);
            robot.Place(position, Direction.NORTH);
        }

        [Test]

        public void TestPlace()
        {
            Assert.AreEqual(robot.Report(), @"Output: 0,0,NORTH");
        }

        [Test]
        public void TestMoveFacingNorth()
        {
            robot.Move();
            Assert.AreEqual(robot.Report(), @"Output: 0,1,NORTH");
        }

        [Test]
        public void TestMoveTwiceFacingNORTH()
        {
            robot.Move();
            robot.Move();
            Assert.AreEqual(robot.Report(), @"Output: 0,2,NORTH");
        }



        [Test]
        public void TestTurnLeft()
        {
            robot.TurnLeft();
            Assert.AreEqual(robot.Report(), @"Output: 0,0,WEST");
        }
        

        [Test]
        public void TestTurnRight()
        {
            robot.TurnRight();
            Assert.AreEqual(robot.Report(), @"Output: 0,0,EAST");
        }
        [Test]
        public void TestTurnRightFourTime()
        {
            robot.TurnRight();
            robot.TurnRight();
            robot.TurnRight();
            robot.TurnRight();
            Assert.AreEqual(robot.Report(), @"Output: 0,0,NORTH");
        }
        [Test]
        public void TestTurnLeftFiveTime()
        {
            robot.TurnLeft();
            robot.TurnLeft();
            robot.TurnLeft();
            robot.TurnLeft();
            robot.TurnLeft();
            Assert.AreEqual(robot.Report(), @"Output: 0,0,WEST");
        }
    }
}