using System.Collections.Generic;
using System.Security.Cryptography;

namespace auernautica_imperiali {
    public abstract class AUnit : Point {
        private int _structure;
        private int _speed;
        private int _throttle;
        private readonly int _minSpeed;
        private readonly int _maxSpeed;
        private int _maneuver;
        private readonly int _handling;
        private readonly int _maxAltitude;
        private readonly int _team;
        private readonly int _cost;
        private readonly List<Weapon> weapons = new List<Weapon>();
        private IMoveBehaviour _moveBehaviour = new DefaultMoveBehaviour();

        public int MinSpeed => _minSpeed;

        public int MaxSpeed => _maxSpeed;

        public int Handling => _handling;

        public int MaxAltitude => _maxAltitude;

        public int Team => _team;

        public int Cost => _cost;

        public List<Weapon> Weapons => weapons;

        public int Structure {
            get => _structure;
            set => _structure = value;
        }

        public int Speed {
            get => _speed;
            set => _speed = value;
        }

        public int Throttle {
            get => _throttle;
            set => _throttle = value;
        }

        public int Maneuver {
            get => _maneuver;
            set => _maneuver = value;
        }

        private Point _point;

        public Point Point {
            get { return _point; }
            set { _point = value; }
        }


        protected AUnit(Point p, int structure, int speed, int throttle, int minSpeed, int maxSpeed,
            int maneuver, int handling, int maxAltitude, int team, int cost) : base(p.X, p.Y, p.Z) {
            _structure = structure;
            _speed = speed;
            _throttle = throttle;
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _maneuver = maneuver;
            _handling = handling;
            _maxAltitude = maxAltitude;
            _team = team;
            _cost = cost;
        }

        public abstract bool JoinArmy();

        public void AddWeapon(Weapon weapon) {
            weapons.Add(weapon);
        }

        public void SetLocation(Point p) {
            this.X = p.X;
            this.Y = p.Y;
            this.Z = p.Z;
        }

        public MovementCost CalculateMoveCost(List<Point> route) {
            int maneuverCost = 0;
            int speedCost = 0;
            int fieldCost = 0;
            if (route.Count <= 1)    //wtf pani
                return new MovementCost(1, 1, 1);

            int prevIndex = 0;
            Point previous = route[prevIndex];
            int currIndex = 1;
            Point current = route[currIndex];

            for (int i = 0; i < route.Count; i++) {
                if (previous.X != current.X) {
                    if (previous.Y != current.Y)
                        maneuverCost++;

                    speedCost++;
                }

                if (previous.X == current.X && previous.Y != current.Y) {
                    speedCost++;
                }

                if (previous.Z != current.Z) {
                    speedCost++;
                }

                if (currIndex + 1 >= route.Count) {
                    break;
                }

                previous = route[++prevIndex];
                current = route[++currIndex];
                fieldCost++;
            }
            return new MovementCost(maneuverCost,speedCost, fieldCost);
        }
    }
}