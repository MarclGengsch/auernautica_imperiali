namespace auernautica_imperiali {
    public class Spinbehaviour : IMoveBehaviour {
        private AUnit _aircraft;

        public Spinbehaviour(AUnit aircraft) {
            _aircraft = aircraft;
        }

        public void Move(Point destination, int throttle) {
            if (HandlingTest(_aircraft)) {
                _aircraft.Speed = _aircraft.MinSpeed;
                _aircraft.MoveBehaviour = new DefaultMoveBehaviour(_aircraft);
                return;
            }

            if (--_aircraft.Z <= 0) {
                _aircraft.RemoveAircraft();
            }
        }

        public static bool IsSpin(AUnit aircraft) {
            if (aircraft.Speed > aircraft.MaxSpeed || aircraft.Speed < aircraft.MinSpeed ||
                aircraft.Z > aircraft.MaxAltitude)
                return true;

            return false;
        }

        public bool HandlingTest(AUnit aircraft) {
            if (Dice.GetInstance().RollDice() >= aircraft.Handling)
                return true;

            return false;
        }
    }
}