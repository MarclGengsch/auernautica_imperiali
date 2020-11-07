using System;
using System.Linq;
using System.Threading.Channels;
using NUnit.Framework;

namespace auernautica_imperiali.unittest {
    public class Tests {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PointTest()
        {
            Point p1 = new Point(1, 2, 3);
            Point p2 = new Point(1, 2, 3);
            Point p3 = new Point(2, 4, 3);
            Point p4 = new Point(15, 3, 3);
            Point p5 = new Point(14, 2, 3);
            AirCraftFactory.GetInstance().MakeAircraft(1, 2, 3, EAirCraftType.EXECUTIONER);
            Assert.True(p1.Equals(p2));
            Assert.False(p1.Equals(p3));
            Assert.AreEqual("X: 1, Y: 2, Z: 3", p1.ToString());
            Assert.False(p1.IsPointFree());
            Assert.True(p3.IsPointFree());
            Assert.False(p4.IsPointLegal());
            Assert.AreEqual(14, p1.CalculateRoute(p4).Count);
            Assert.AreEqual(1, p5.CalculateRoute(p4).Count);

            Assert.AreEqual(2, p1.CalculateDistance(p3));
            Assert.AreEqual(0, p1.CalculateDistance(p1));

            Assert.Pass();
        }

        [Test]
        public void PlayerTest()
        {
            Logger.LOG_TO_CONSOLE = true;
            AirCraftFactory.GetInstance().MakeAircraft(14, 14, 1, EAirCraftType.VULTURE);
            Assert.AreEqual(150 - 23, Player.getOrk().Coins);
            AirCraftFactory.GetInstance().MakeAircraft(14, 1, 1, EAirCraftType.BLUEDEVIL);
            Assert.AreEqual(150 - 26, Player.getImperiali().Coins);
            //points sind zu zufällig um sie zu testen
        }

        [Test]
        public void AUintTest()
        {
            AirCraftFactory.GetInstance().MakeAircraft(1, 13, 1, EAirCraftType.BIGBURNA);
            Point p = new Point(1, 1, 1);
            GameEngine.OrkList[0].SetLocation(p);
            Assert.AreEqual("X: 1, Y: 1, Z: 1", GameEngine.OrkList[0].ToString());
            
            
            
        }
    }
}