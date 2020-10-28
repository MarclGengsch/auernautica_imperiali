using System;

namespace auernautica_imperiali {
    public class Dice {
        Random _random = new Random();
        private Dice _dice = new Dice();

        public Dice GetInstance() {
            return _dice;
        }
        
        public int RollDice(int max) {
            return _random.Next(0, max + 1);
        }
    }
}