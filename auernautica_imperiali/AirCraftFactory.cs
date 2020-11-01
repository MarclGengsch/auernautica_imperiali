﻿using System;

namespace auernautica_imperiali {
    public class AirCraftFactory {
        private AirCraftFactory()
        {
        }
        private static AirCraftFactory instance = new AirCraftFactory();
        public static AirCraftFactory GetInstance() {
            return instance;
        }

        public void MakeAircraft(int x, int y, int z, EAirCraftType type)
        {
            AUnit unit;
            switch (type)
            {
                case EAirCraftType.BIGBURNA:
                    unit = new AOrk(new Point(x, y, z), 3, 3, 2, 3, 7, 4, 4, 4, 22 );
                    break;
                case EAirCraftType.VULTURE:
                    unit = new AOrk(new Point(x, y, z), 2, 3, 2, 3, 8, 5, 3, 4, 23); 
                    break;
                case EAirCraftType.GROTBOMMER:
                    unit = new AOrk(new Point(x, y, z), 6, 2, 1, 2, 4, 3, 5, 4, 28); 
                    break;
                case EAirCraftType.BLUEDEVIL:
                    unit = new AImperiali(new Point(x, y, z), 5, 2, 1, 2, 5, 3, 3, 5, 26); 
                    break;
                case EAirCraftType.HELLION:
                    unit = new AImperiali(new Point(x, y, z), 2, 2, 3, 2, 8, 7, 2, 5, 26); 
                    break;
                case EAirCraftType.EXECUTINER:
                    unit = new AImperiali(new Point(x, y, z), 3, 2, 2, 2, 7, 6, 3, 5, 23); 
                    break;
                default:
                    throw new ArgumentException();
            }
            if(!unit.JoinArmy())
                Console.WriteLine("Error");
            else
            {
                Console.WriteLine("Success");
            }
        }
        
    }
}
//GameEngine.OrkList.Add(new AOrk(new Point(x, y, z), 3, 3, 2, 3, 7, 4, 4, 4, 22 ));