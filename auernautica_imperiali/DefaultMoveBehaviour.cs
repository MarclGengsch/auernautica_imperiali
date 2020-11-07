using System.Collections.Generic;

namespace auernautica_imperiali {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        private AUnit _aircraft;

        public DefaultMoveBehaviour(AUnit aircraft)
        {
            _aircraft = aircraft;
        }

        //calc rout hängt
        public void Move(Point destination)
        {
            List<Point> route = _aircraft.CalculateRoute(destination);
            MovementCost costs = _aircraft.CalculateMoveCost(route);
            int shipSpeed = _aircraft.Speed;
            for (int i = 0; i < costs.FieldCount && shipSpeed > 0; i++, shipSpeed--)
            {
                if (route[i].IsPointLegal())
                    _aircraft.SetLocation(route[i]);
                else
                    break;
            }

            if (Spinbehaviour.IsSpin(_aircraft))
            {
                _aircraft.MoveBehaviour = new Spinbehaviour(_aircraft);
            }
        }
    }
}