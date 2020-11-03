using System.Collections.Generic;

namespace auernautica_imperiali {
    public class DefaultMoveBehaviour : IMoveBehaviour {

        public void Move(AUnit aircraft, Point destination) {
            List<Point> route = aircraft.CalculateRoute(destination);
            MovementCost costs = aircraft.CalculateMoveCost(route);
            for (int i = 0; i < costs.FieldCount; i++) {
                aircraft.SetLocation(route[i]);
            }
        }
        
    }
}