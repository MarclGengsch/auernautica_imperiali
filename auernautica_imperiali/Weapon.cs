using System.Collections.Generic;

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

        public int CountSuccessfulAttacks() {
            int count = 0;

            foreach (ERange rangeTableKey in _rangeTable.Keys) {
                foreach (int rangeTableValue in _rangeTable.Values) {
                    if (IsAttackSuccessful()) {
                        count++;
                    }
                }
            }
            
            return count;
        }

        public void Attack(AUnit aircraft) {
            aircraft.Structure -= CountSuccessfulAttacks();
            if (aircraft.Structure <= 0) {
                aircraft.RemoveAircraft();
            }
        }
    }
}