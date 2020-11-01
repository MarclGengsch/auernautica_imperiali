using System;

namespace auernautica_imperiali {
    class Program {
        static void Main(string[] args) {
            AirCraftFactory.GetInstance().MakeAircraft(2,2,4, EAirCraftType.BIGBURNA);
            
            GameEngine.GetInstance().map.PrintMap();
        }
    }
}