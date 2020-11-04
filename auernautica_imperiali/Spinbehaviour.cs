namespace auernautica_imperiali {
    public class Spinbehaviour : IMoveBehaviour {
        public void Move(AUnit aircraft, Point destination) {
            throw new System.NotImplementedException();
        }

        public bool IsSpin(AUnit aircraft) {
            if (aircraft.Speed > aircraft.MaxSpeed || aircraft.Speed < aircraft.MinSpeed || aircraft.Z > aircraft.MaxAltitude) 
                return HandlingTest(aircraft);    //??????

            return false;
        }

        public bool HandlingTest(AUnit aircraft) {
            if (Dice.GetInstance().RollDice() >= aircraft.Handling) {
                aircraft.MoveBehaviour = new DefaultMoveBehaviour();
                return true;
            }

            --aircraft.Z;

            if (aircraft.Z <= 0) {
                aircraft.RemoveAircraft();
            }

            return false;
        }
    }
}