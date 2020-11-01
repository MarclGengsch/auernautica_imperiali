using System;

namespace auernautica_imperiali {
    class Program {
        static void Main(string[] args) {
            AirCraftFactory.GetInstance().MakeAircraft(3,14,1, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(4,14,2, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(5,14,3, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(6,14,4, EAirCraftType.BIGBURNA);
            AirCraftFactory.GetInstance().MakeAircraft(7,14,5, EAirCraftType.BIGBURNA);
            
            GameEngine.GetInstance().map.PrintMap();
        }
    }
}