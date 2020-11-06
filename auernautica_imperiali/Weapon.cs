﻿using System.Collections.Generic;

namespace auernautica_imperiali {
    public class Weapon {
        private int _damage;
        private Dictionary<ERange, int> _rangeTable = new Dictionary<ERange, int>();
        private List<EFireArc> _fireDirection = new List<EFireArc>();
        

        public Weapon(List<EFireArc> fireDirections, List<int> fireRanges, int damage) {
            _fireDirection = fireDirections;
            _rangeTable[ERange.SHORT] = fireRanges[0];
            _rangeTable[ERange.MEDIUM] = fireRanges[1];
            _rangeTable[ERange.LONG] = fireRanges[2];
            _damage = damage;
        }

        public bool IsAttackSuccessful() {
            if (Dice.GetInstance().RollDice() >= _damage) {
                return true;
            }

            return false;
        }

        public int CountSuccessfulAttacks(ERange range) {
            int count = 0;

            for (int i = 0; i < _rangeTable[range]; i++) {
                if (IsAttackSuccessful()) {
                    count++;
                }
            }

            return count;
        }

        public void Attack(AUnit aircraft, ERange range) {
            aircraft.Structure -= CountSuccessfulAttacks(range);
            if (aircraft.Structure <= 0)
            {
                if (aircraft.Team == 1)
                    Player.getOrk().Points += aircraft.Cost;
                else
                    Player.getImperiali().Points += aircraft.Cost;
                
                aircraft.RemoveAircraft();
            }
        }
    }
}