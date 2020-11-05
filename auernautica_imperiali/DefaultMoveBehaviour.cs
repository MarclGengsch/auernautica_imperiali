using System.Collections.Generic;

namespace auernautica_imperiali {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        private AUnit _aircraft;
        public DefaultMoveBehaviour(AUnit aircraft) {
            _aircraft = aircraft;
        }

        public void Move(Point destination) {
            List<Point> route = _aircraft.CalculateRoute(destination);
            MovementCost costs = _aircraft.CalculateMoveCost(route);
            for (int i = 0; i < costs.FieldCount; i++) {
                _aircraft.SetLocation(route[i]);
            }

            if (Spinbehaviour.IsSpin(_aircraft)) {
                _aircraft.MoveBehaviour = new Spinbehaviour(_aircraft);
            }
        }
    }
}