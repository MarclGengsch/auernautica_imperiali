using System;
using System.Linq;
using NUnit.Framework;

namespace auernautica_imperiali.unittest {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Point() {
            Point p1 = new Point(1, 2, 3);
            Point p2 = new Point(1, 2, 3);
            Point p3 = new Point(2, 3, 3);
            Point p4 = new Point(15, 3, 3);
            AirCraftFactory.GetInstance().MakeAircraft(1, 2, 3, EAirCraftType.EXECUTIONER);
            Assert.True(p1.Equals(p2));
            //Assert.False(p1.Equals(p3));
            Assert.AreEqual("X: 1, Y: 2, Z: 3", p1.ToString());
            Assert.False(p1.IsPointFree());
            //Assert.True(p3.IsPointFree());
            Assert.False(p4.IsPointLegal());
            Console.WriteLine(p1.CalculateRoute(p3).Count);
            
            //Assert.AreEqual(3, p1.CalculateDistance(p3));
            //Assert.AreEqual(0, p1.CalculateDistance(p1));
            
            Assert.Pass();
            
        }
    }
}