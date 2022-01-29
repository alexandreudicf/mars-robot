using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRobot.Tests
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod]
        public void TestBounds()
        {
            //North
            var (x, y, cardinalDirection) = new Robot().MyPosition(new int[] { 5, 5 }, new char[] { 'F', 'F', 'F', 'F', 'F', 'F' });
            //East
            var (x2, y2, cardinalDirection2) = new Robot().MyPosition(new int[] { 5, 5 }, new char[] { 'R', 'F', 'F', 'F', 'F', 'F', 'F' });
            //West
            var (x3, y3, cardinalDirection3) = new Robot().MyPosition(new int[] { 5, 5 }, new char[] { 'L', 'F', 'F', 'F', 'F', 'F', 'F' });

            Assert.IsTrue(x == 1 && y == 5 && cardinalDirection == "North");
            Assert.IsTrue(x2 == 5 && y2 == 1 && cardinalDirection2 == "East");
            Assert.IsTrue(x3 == 1 && y3 == 1 && cardinalDirection3 == "West");
        }

        [TestMethod]
        public void TestFinalPositions()
        {
            var (x, y, cardinalDirection) = new Robot().MyPosition(new int[] { 5, 5 }, "FFRFLFLF"!.ToCharArray());
            Assert.IsTrue(x == 1 && y == 4 && cardinalDirection == "West");

            var (x2, y2, cardinalDirection2) = new Robot().MyPosition(new int[] { 5, 5 }, "RFFFLFRFLF"!.ToCharArray());
            Assert.IsTrue(x2 == 5 && y2 == 3 && cardinalDirection2 == "North");

            var (x3, y3, cardinalDirection3) = new Robot().MyPosition(new int[] { 2, 2 }, "RFFLFL"!.ToCharArray());
            Assert.IsTrue(x3 == 2 && y3 == 2 && cardinalDirection3 == "West");

            var (x4, y4, cardinalDirection4) = new Robot().MyPosition(new int[] { 2, 2 }, "F"!.ToCharArray());
            Assert.IsTrue(x4 == 1 && y4 == 2 && cardinalDirection4 == "North");

            var (x5, y5, cardinalDirection5) = new Robot().MyPosition(new int[] { 3, 3 }, "RFFLFLFRRFLFR"!.ToCharArray());
            Assert.IsTrue(x5 == 3 && y5 == 3 && cardinalDirection5 == "East");

            var (x6, y6, cardinalDirection6) = new Robot().MyPosition(new int[] { 1, 1 }, "RFFR"!.ToCharArray());
            Assert.IsTrue(x6 == 1 && y6 == 1 && cardinalDirection6 == "South");
        }

    }
}