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
    }
}