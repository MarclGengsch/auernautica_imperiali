using System;
using System.Threading;

namespace auernautica_imperiali {
    public class Map {
        public const int Altitude = 5, Width = 15, Height = 15;
        public Map() {
        }

        public void PrintMap() {
            for (int i = 1; i <= Altitude; i++) {
                for (int j = 1; j <= Height; j++) {
                    for (int k = 1; k <= Width; k++) {
                        bool written = false;
                        foreach (var _orks in GameEngine.OrkList) {
                            if (_orks.Point.Equals(new Point(k,j,i))) {
                                Console.Write("o ");
                                written = true;
                            }
                        }
                        foreach (var _imperiali in GameEngine.ImperialiList) {
                            if (_imperiali.Point.Equals(new Point(k,j,i))) {
                                Console.Write("i ");
                                written = true;
                            } 
                        }
                        if (!written) {
                            Console.Write("_ ");
                        }
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
        
        //public PlaceAirCraft()
    }
}