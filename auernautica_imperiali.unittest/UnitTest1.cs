using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using NUnit.Framework;

namespace auernautica_imperiali.unittest {
    public class Tests {
        [SetUp]
        public void Setup() //achtung nd alle auf einmal testen
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

            Assert.True(p4.IsPointLegal());

            Assert.AreEqual(15, p1.CalculateRoute(p4).Count);
            Assert.AreEqual(2, p5.CalculateRoute(p4).Count);

            Assert.AreEqual(2, p1.CalculateDistance(p3));
            Assert.AreEqual(0, p1.CalculateDistance(p1));

            Assert.Pass();
        }

        [Test]
        public void PlayerTest() //muss einzeln ausgeführt werden
        {
            Logger.LOG_TO_CONSOLE = true;
            AirCraftFactory.GetInstance().MakeAircraft(14, 14, 1, EAirCraftType.VULTURE);
            Assert.AreEqual(150 - 23, Player.getOrk().Coins);
            AirCraftFactory.GetInstance().MakeAircraft(14, 1, 1, EAirCraftType.BLUEDEVIL);
            Assert.AreEqual(150 - 26, Player.getImperiali().Coins);
            //points sind zu zufällig um sie zu testen
        }

        [Test]
        public void MoveCommandTest()
        {
            AirCraftFactory.GetInstance().MakeAircraft(3, 14, 1, EAirCraftType.BIGBURNA);
            List<ICommand> commands = new List<ICommand>();
            Point destination = new Point(15, 14, 4);
            ICommand move = new MoveCommand(GameEngine.OrkList[0], destination, 0);
            commands.Add(move);
            GameEngine.GetInstance().ExecuteCommands(commands);
            Assert.AreEqual("X: 6, Y: 14, Z: 4", GameEngine.OrkList[0].ToString());
        }

        [Test]
        public void AUnitTest()
        {
            //ConvertRange
            Point p1 = new Point(2, 1, 1);
            Point p2 = new Point(6, 1, 1);
            Point p3 = new Point(10, 1, 1);
            AirCraftFactory.GetInstance().MakeAircraft(1, 1, 1, EAirCraftType.BLUEDEVIL);
            Assert.AreEqual(ERange.SHORT, GameEngine.ImperialiList[0].ConvertRange(p1));
            Assert.AreEqual(ERange.MEDIUM, GameEngine.ImperialiList[0].ConvertRange(p2));
            Assert.AreEqual(ERange.LONG, GameEngine.ImperialiList[0].ConvertRange(p3));

            //MoveCost
            Assert.AreEqual(5,
                GameEngine.ImperialiList[0].CalculateMoveCost(GameEngine.ImperialiList[0].CalculateRoute(p2))
                    .SpeedCost);
            Assert.AreEqual(0,
                GameEngine.ImperialiList[0].CalculateMoveCost(GameEngine.ImperialiList[0].CalculateRoute(p2))
                    .ManeuverCost);
            Assert.AreEqual(5,
                GameEngine.ImperialiList[0].CalculateMoveCost(GameEngine.ImperialiList[0].CalculateRoute(p2))
                    .FieldCount);
        }

        [Test]
        public void UnitGetDirectionTest()
        {
            //GetDirection
            AirCraftFactory.GetInstance().MakeAircraft(2, 2, 1, EAirCraftType.BLUEDEVIL);
            AirCraftFactory.GetInstance().MakeAircraft(2, 14, 1, EAirCraftType.GROTBOMMER);
            Assert.AreEqual(EFireArc.FRONT, GameEngine.OrkList[0].GetDirection(GameEngine.ImperialiList[0]));
            Assert.AreEqual(EFireArc.FRONT, GameEngine.ImperialiList[0].GetDirection(GameEngine.OrkList[0]));
        }
        
        
        
        [Test]
        public void AOrkTest()
        {
            //JoinArmy
            AOrk unit = new AOrk(new Point(1, 15, 1), 3, 3, 2, 3, 7, 4, 4, 4, 22);
            AOrk unit1 = new AOrk(new Point(1, 1, 1), 3, 3, 2, 3, 7, 4, 4, 4, 22);
            Assert.IsTrue(unit.JoinArmy());
            Assert.IsFalse(unit1.JoinArmy());
        }

        [Test]
        public void AImperialiTest()
        {
            //JoinArmy
            AImperiali unit = new AImperiali(new Point(1, 1, 1), 3, 3, 2, 3, 7, 4, 4, 4, 22);
            AImperiali unit1 = new AImperiali(new Point(1, 15, 1), 3, 3, 2, 3, 7, 4, 4, 4, 22);
            Assert.IsTrue(unit.JoinArmy());
            Assert.IsFalse(unit1.JoinArmy());
        }

        [Test]
        public void AirCraftFactoryTest()
        {
            AirCraftFactory.GetInstance().MakeAircraft(1, 1, 1, EAirCraftType.BLUEDEVIL);
            Assert.AreEqual("X: 1, Y: 1, Z: 1", GameEngine.ImperialiList[0].ToString());
            Assert.AreEqual(1, GameEngine.ImperialiList.Count);

            AirCraftFactory.GetInstance().MakeAircraft(1, 15, 1, EAirCraftType.VULTURE);
            Assert.AreEqual("X: 1, Y: 15, Z: 1", GameEngine.OrkList[0].ToString());
            Assert.AreEqual(1, GameEngine.OrkList.Count);
        }

        [Test]
        public void SpinTest()
        {
            //Logger.LOG_TO_CONSOLE = true;
            AirCraftFactory.GetInstance().MakeAircraft(1, 1, 1, EAirCraftType.BLUEDEVIL);
            GameEngine.ImperialiList[0].Speed = 10;
            Assert.IsTrue(Spinbehaviour.IsSpin(GameEngine.ImperialiList[0]));
            GameEngine.ImperialiList[0].Speed = 1;
            Assert.IsTrue(Spinbehaviour.IsSpin(GameEngine.ImperialiList[0]));
            AirCraftFactory.GetInstance().MakeAircraft(2, 14, 3, EAirCraftType.BIGBURNA);
            GameEngine.OrkList[0].Z = 5;
            Assert.IsTrue(Spinbehaviour.IsSpin(GameEngine.OrkList[0]));



        }
    }
}