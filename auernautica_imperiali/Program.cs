using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace auernautica_imperiali {
    class Program {
        static void Main(string[] args)
        {
            Logger.LOG_TO_CONSOLE = true;
            AirCraftFactory.GetInstance().MakeAircraft(3,14,1, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(3,1,1, EAirCraftType.BIGBURNA);
            Console.WriteLine();
            //AirCraftFactory.GetInstance().MakeAircraft(4,14,2, EAirCraftType.BIGBURNA);
            //AirCraftFactory.GetInstance().MakeAircraft(5,14,3, EAirCraftType.BIGBURNA);
            //AirCraftFactory.GetInstance().MakeAircraft(6,14,4, EAirCraftType.BIGBURNA);
            //AirCraftFactory.GetInstance().MakeAircraft(7,14,5, EAirCraftType.BIGBURNA);
            //AirCraftFactory.GetInstance().MakeAircraft(7,1,2, EAirCraftType.BLUEDEVIL);
            GameEngine.GetInstance().map.PrintMap();
            
            List<ICommand> commands = new List<ICommand>();
            Point destination = new Point(2,9,3);
            ICommand move = new MoveCommand(GameEngine.OrkList[0], destination);
            commands.Add(move);
            GameEngine.GetInstance().ExecuteCommands(commands);
            //TestZweck
            
            GameEngine.GetInstance().map.PrintMap();
            
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