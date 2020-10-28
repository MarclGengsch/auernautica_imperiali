namespace auernautica_imperiali {
    public class AImperiali : AUnit {
        public AImperiali(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed, int maneuver,
            int handling, int maxAltitude, int cost) : base(xyz, structure, speed, throttle, minSpeed, maxSpeed, maneuver,
            handling, maxAltitude, 2, cost) {
        }
    }
}