namespace auernautica_imperiali {
    public class AOrk : AUnit {
        public AOrk(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed,
            int maneuver, int handling, int maxAltitude) : base(xyz, structure, speed, throttle, minSpeed, maxSpeed,
            maneuver, handling, maxAltitude, 1) {
        }
    }
}