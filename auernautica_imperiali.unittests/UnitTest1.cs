using System.Drawing;
using NUnit.Framework;

namespace auernautica_imperiali.unittests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Test1() {
            
            Assert.IsTrue(new Point(1,2,3).Equals(new Point(1,2,3)));
        }
    }
}