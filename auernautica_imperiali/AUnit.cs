using System.Collections.Generic;

namespace auernautica_imperiali {
    public abstract class AUnit {
        private int _structure;
        private int _speed;
        private int _throttle;
        private int _minSpeed;
        private int _maxSpeed;
        private int _maneuver;
        private int _handling;
        private int _maxAltitude;
        private int _team;
        private static List<AOrk> _orkList = new List<AOrk>();
        private static List<AImperiali> _imperialiList = new List<AImperiali>();

        public static List<AOrk> OrkList {
            get => _orkList;
            set => _orkList = value;
        }

        public static List<AImperiali> ImperialiList {
            get => _imperialiList;
            set => _imperialiList = value;
        }


        protected AUnit(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed,
            int maneuver, int handling, int maxAltitude, int team) {
            _structure = structure;
            _speed = speed;
            _throttle = throttle;
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _maneuver = maneuver;
            _handling = handling;
            _maxAltitude = maxAltitude;
            _team = team;
        }
    }
}