using System;
using System.Threading;

namespace auernautica_imperiali {
    public class Map {
        public Map() {
        }

        public void PrintMap() {
            for (int i = 1; i <= 5; i++) {
                for (int j = 1; j <= 15; j++) {
                    for (int k = 1; k <= 15; k++) {
                        bool written = false;
                        foreach (var _orks in AUnit.OrkList) {
                            if (_orks.Point.Equals(new Point(j,k,i))) {
                                Console.Write("o");
                                written = true;
                            }
                        }
                        foreach (var _imperiali in AUnit.ImperialiList) {
                            if (_imperiali.Point.Equals(new Point(j,k,i))) {
                                Console.Write("i");
                                written = true;
                            } 
                        }
                        if (!written) {
                            Console.Write("_");
                        }
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
        
        
    }
}