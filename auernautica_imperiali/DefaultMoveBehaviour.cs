﻿using System;
using System.Collections.Generic;

namespace auernautica_imperiali {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        private AUnit _aircraft;

        public DefaultMoveBehaviour(AUnit aircraft) {
            _aircraft = aircraft;
        }

        public void Move(Point destination, int throttle) {
            List<Point> route = _aircraft.CalculateRoute(destination);
            MovementCost costs = _aircraft.CalculateMoveCost(route);
            if (throttle > _aircraft.Throttle) {
                throw new Exception();
            }

            _aircraft.Speed += throttle;
            int shipSpeed = _aircraft.Speed;

            for (int i = 1; i <= costs.FieldCount && shipSpeed > 0; i++, shipSpeed--) {
                if (route[i].IsPointLegal())
                    _aircraft.SetLocation(route[i]);
                else
                    break;
            }

            if (Spinbehaviour.IsSpin(_aircraft)) {
                _aircraft.MoveBehaviour = new Spinbehaviour(_aircraft);
            }
        }
    }
}