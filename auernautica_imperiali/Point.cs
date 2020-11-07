using System;
using System.Collections.Generic;

namespace auernautica_imperiali {
    public class Point {        //unittest fertig
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
        

        public override string ToString() {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}, {nameof(Z)}: {Z}";
        }

        public bool IsPointLegal()
        {
            if (Z >= Map.Altitude || X >= Map.Width || Y >= Map.Height || !IsPointFree())
                return false;
            return true;
        }

        public bool IsPointFree()
        {
            foreach (var _orks in GameEngine.OrkList)
            {
                if (_orks.Equals(this))
                {
                    return false;
                }
            }
            foreach (var _imperiali in GameEngine.ImperialiList) {
                if (_imperiali.Equals(this))
                {
                    return false;
                } 
            }
            return true;
        } 
        
        public List<Point> CalculateRoute(Point destination) {
    
            List<Point> route = new List<Point>();
            Point p = new Point(_x, _y, _z);
            int stepcountx = (_x == destination.X) ? 0 : (_x < destination.X) ? 1 : -1;
            int stepcounty = (_y == destination.Y) ? 0 : (_y < destination.Y) ? 1 : -1;
            int stepcountz = (_z == destination.Z) ? 0 : (_z < destination.Z) ? 1 : -1;
            int diffX = Math.Abs(this._x - destination.X);
            int diffY = Math.Abs(this._y - destination.Y);
            int diffZ = Math.Min(Math.Max(diffX, diffY), Math.Abs(this._z - destination.Z));
    
            for (int i = 0, j = 0, k = 0, step = 0; step < Math.Max(diffX, diffY); step++)
            {
                route.Add(new Point(_x + (i * stepcountx), _y + (j * stepcounty), _z + (k * stepcountz)));
                if (i < diffX) ++i;
                if (j < diffY) ++j;
                if (k < diffZ) ++k;
            }
    
            return route;
        }

        public int CalculateDistance(Point end) {
            return (int)Math.Sqrt(Math.Pow(X - end.X, 2) + Math.Pow(Y - end.Y, 2) + Math.Pow(Z - end.Z, 2));
        }
    }
}