﻿using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace auernautica_imperiali {
    class Program {
        static void Main(string[] args)
        {
            Logger.LOG_TO_CONSOLE = true;
            /*
            AirCraftFactory.GetInstance().MakeAircraft(1, 1, 1, EAirCraftType.BLUEDEVIL);
            GameEngine.GetInstance().map.PrintMap();
            Point p = new Point(4, 3, 1);
            Console.WriteLine(GameEngine.ImperialiList[0].CalculateMoveCost(GameEngine.ImperialiList[0].CalculateRoute(p)).ManeuverCost);
            Console.WriteLine(GameEngine.ImperialiList[0].CalculateMoveCost(GameEngine.ImperialiList[0].CalculateRoute(p)).SpeedCost);
            */

            //    FactoryTest
            /*
            AirCraftFactory.GetInstance().MakeAircraft(4,14,2, EAirCraftType.BIGBURNA);             
            AirCraftFactory.GetInstance().MakeAircraft(5,14,3, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(6,14,4, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(7,14,5, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(7,1,2, EAirCraftType.BLUEDEVIL);
            GameEngine.GetInstance().map.PrintMap();
            */


            //    MoveTest
            /*
            AirCraftFactory.GetInstance().MakeAircraft(3,14,1, EAirCraftType.BIGBURNA);
            GameEngine.GetInstance().map.PrintMap();
            List<ICommand> commands = new List<ICommand>();
            Point destination = new Point(15,14,4);
            ICommand move = new MoveCommand(GameEngine.OrkList[0], destination, 0);
            commands.Add(move);
            GameEngine.GetInstance().ExecuteCommands(commands);
            //TestZweck            
            GameEngine.GetInstance().map.PrintMap();
            */


            /*Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["hallo"] = "hallo";
            dic["hi"] = "hallo";
            dic["hola"] = "hallo";

            foreach (var VARIABLE in dic.Keys)
            {
                Console.WriteLine(VARIABLE);
            }*/
        }
    }
}