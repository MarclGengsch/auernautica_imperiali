
namespace auernautica_imperiali {
    public class AOrk : AUnit {        //unittests fertig da die methoden alle private sind und in der joinarmy verwendet werdne
        public AOrk(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed,
            int maneuver, int handling, int maxAltitude, int cost) : base(xyz, structure, speed, throttle, minSpeed, maxSpeed,
            maneuver, handling, maxAltitude, 1, cost) {
        }

        public override bool JoinArmy()
        {
            if (!IsPointLegal() || !IsStartField() || !IsPurchaseLegal() || !IsAltitudeLegal())
            {
                return false;
            }
            GameEngine.OrkList.Add(this);
            Player.getOrk().Coins -= Cost;
            return true;
        }
        
        private bool IsStartField()
        {
            if (Y == Map.Height - 2 || Y ==  Map.Height - 1 || Y == Map.Height)
                return true;

            return false;
        }
        
        private bool IsPurchaseLegal()
        {
            return Cost <= Player.getOrk().Coins;
        }
        
        private bool IsAltitudeLegal()
        {
            return MaxAltitude >= Z;
        }
        
        protected bool Equals(Point other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals((Point) obj);
        }
    }
}