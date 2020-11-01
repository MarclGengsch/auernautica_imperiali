using System;

namespace auernautica_imperiali {
    public class AImperiali : AUnit {
        public AImperiali(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed, int maneuver,
            int handling, int maxAltitude, int cost) : base(xyz, structure, speed, throttle, minSpeed, maxSpeed, maneuver,
            handling, maxAltitude, 2, cost) {
        }

        public override bool JoinArmy()
        {
            if (!this.Point.IsPointLegal() || !IsStartField(Point) || !IsPurchaseLegal() || !IsAltitudeLegal())
            {
                return false;
            }
            GameEngine.ImperialiList.Add(this);
            Player.getImperiali().Coins -= Cost;
            return true;
        }

        private bool IsStartField(Point p)
        {
            if (Point.Y == 0 || Point.Y == 1 || Point.Y == 2)
                return true;
            return false;
        }

        private bool IsPurchaseLegal()
        {
            return Cost <= Player.getImperiali().Coins;
        }

        private bool IsAltitudeLegal()
        {
            return MaxAltitude >= Point.Z;
        }
    }
}