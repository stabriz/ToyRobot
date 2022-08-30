using NUnit.Framework;
using ToyRobot.Enums;


namespace ToyRobot.NUnitTest
{
    public class TableTest
    {
        Table _table;

        [SetUp]
        public void Setup()
        {
            _table = new Table(6, 6);
        }

        [Test]
        [TestCase(0, 0, ExpectedResult = true)]
        [TestCase(6, 6, ExpectedResult = true)]
        [TestCase(-1, 0, ExpectedResult = false)]
        [TestCase(-1, -1, ExpectedResult = false)]
        [TestCase(1, -7, ExpectedResult = false)]
        [TestCase(-7, -7, ExpectedResult = false)]
        public bool IsValidPositionWithinTableTest(int x, int y)
        {
            Position position = new Position(x, y);
            return _table.IsValidPosition(position);
        }
    }
}
