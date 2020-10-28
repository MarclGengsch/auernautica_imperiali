using System;

namespace auernautica_imperiali {
    class Program {
        static void Main(string[] args) {
            Map map = new Map();
            BigBurna burna = new BigBurna(2,2,4 );
            BigBurna burna1 = new BigBurna(6,2,4 );
            BigBurna burna2 = new BigBurna(3,2,4 );
            
            Executioner ex = new Executioner(5, 5, 4);
            Executioner ex1 = new Executioner(5, 7, 4);
            Executioner ex2 = new Executioner(5, 10, 4);
            
            map.PrintMap();
        }
    }
}