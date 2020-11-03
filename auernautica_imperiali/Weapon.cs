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
    }
}