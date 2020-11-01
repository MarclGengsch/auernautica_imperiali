using System;

namespace auernautica_imperiali {
    public class AOrk : AUnit {
        public AOrk(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed,
            int maneuver, int handling, int maxAltitude, int cost) : base(xyz, structure, speed, throttle, minSpeed, maxSpeed,
            maneuver, handling, maxAltitude, 1, cost) {
        }

        public override bool JoinArmy()
        {
            if (!this.Point.IsPointLegal() || !IsStartField(Point) || !IsPurchaseLegal() || !IsAltitudeLegal())
            {
                return false;
            }
            GameEngine.OrkList.Add(this);
            Player.getOrk().Coins -= Cost;
            return true;
        }
        
        private bool IsStartField(Point p)
        {
            if (Point.Y == Map.Height - 3 || Point.Y ==  Map.Height - 2 || Point.Y == Map.Height - 1)
                return true;

            return false;
        }
        
        private bool IsPurchaseLegal()
        {
            return Cost <= Player.getOrk().Coins;
        }
        
        private bool IsAltitudeLegal()
        {
            return MaxAltitude >= Point.Z;
        }
    }
}