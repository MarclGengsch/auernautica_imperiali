using System;
using System.Collections.Generic;

namespace auernautica_imperiali {
    public class Weapon {
        private int _damage;
        private int _special;
        private Dictionary<ERange, int> _rangeTable = new Dictionary<ERange, int>();
        private List<EFireArc> _fireDirection;
        private AUnit _currenShip;

        public Weapon(List<EFireArc> fireDirections, List<int> fireRanges, int damage, int special, AUnit currentShip) {
            _fireDirection = fireDirections;
            _rangeTable[ERange.SHORT] = fireRanges[0];
            _rangeTable[ERange.MEDIUM] = fireRanges[1];
            _rangeTable[ERange.LONG] = fireRanges[2];
            _damage = damage;
            _special = special;
            _currenShip = currentShip;
        }

        public int CountSuccessfulAttacks(ERange range, int damage) {
            int count = 0;
            for (int i = 0; i < _rangeTable[range]; i++) {
                int rolled = Dice.GetInstance().RollDice();
                if (rolled >= damage) {
                    if (ExtraDamage(rolled))
                        count++;

                    count++;
                }
            }

            return count;
        }

        private bool ExtraDamage(int x) {
            if (x >= _special)
                return true;

            return false;
        }

        public void Attack(AUnit aircraft, ERange range) {
            if (_fireDirection.Contains(_currenShip.GetDirection(aircraft))) {
                if (_currenShip.Z == aircraft.Z + 1 || _currenShip.Z == aircraft.Z - 1)
                    aircraft.Structure -= CountSuccessfulAttacks(range, _damage + 1);
                else if (_currenShip.Z == aircraft.Z)
                    aircraft.Structure -= CountSuccessfulAttacks(range, _damage);
                if (aircraft.Structure <= 0) {
                    if (aircraft.Team == 1)
                        Player.getOrk().Points += aircraft.Cost;
                    else
                        Player.getImperiali().Points += aircraft.Cost;

                    aircraft.RemoveAircraft();
                }
            }
        }
    }
}