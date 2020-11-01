using System;

namespace auernautica_imperiali {
    public class Point {
        private int _x;
        private int _y;
        private int _z;

        public int X {
            get => _x;
            set => _x = value;
        }

        public int Y {
            get => _y;
            set => _y = value;
        }

        public int Z {
            get => _z;
            set => _z = value;
        }

        public Point(int x, int y, int z) {
            _x = x;
            _y = y;
            _z = z;
        }

        protected bool Equals(Point other) {
            return _x == other._x && _y == other._y && _z == other._z;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Point) obj);
        }

        public override int GetHashCode() {
            return HashCode.Combine(_x, _y, _z);
        }

        public override string ToString() {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}, {nameof(Z)}: {Z}";
        }

        public bool IsPointLegal()
        {
            if (Z > Map.MaxAltitude || X >= Map.Width || Y >= Map.Height || !IsPointFree()) //unsure
                return false;
            return true;
        }

        public bool IsPointFree()
        {
            foreach (var _orks in GameEngine.OrkList)
            {
                if (_orks.Point.Equals(this))
                {
                    return false;
                }
            }
            foreach (var _imperiali in GameEngine.ImperialiList) {
                if (_imperiali.Point.Equals(this))
                {
                    return false;
                } 
            }
            return true;
        } 
    }
}