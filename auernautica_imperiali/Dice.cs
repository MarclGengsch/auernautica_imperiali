using System;

namespace auernautica_imperiali {
    public class Dice {
        Random _random = new Random();
        private static Dice _dice = new Dice();

        public static Dice GetInstance() {
            return _dice;
        }

        public int RollDice() {
            return _random.Next(0, 6);
        }

        private Dice() {
            _random = new Random();
        }
    }
}