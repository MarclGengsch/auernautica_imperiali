﻿using System;

namespace auernautica_imperiali {
    public class AImperiali : AUnit {        //unittests fertig da die methoden alle private sind und in der joinarmy verwendet werdne
        public AImperiali(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed, int maneuver,
            int handling, int maxAltitude, int cost) : base(xyz, structure, speed, throttle, minSpeed, maxSpeed, maneuver,
            handling, maxAltitude, 2, cost) {
        }

        public override bool JoinArmy()
        {
            if (!this.IsPointLegal() || !IsStartField() || !IsPurchaseLegal() || !IsAltitudeLegal())
            {
                return false;
            }
            GameEngine.ImperialiList.Add(this);
            Player.getImperiali().Coins -= Cost;
            return true;
        }

        private bool IsStartField()
        {
            if (Y == 1 || Y == 2 || Y == 3)
                return true;
            return false;
        }

        private bool IsPurchaseLegal()
        {
            return Cost <= Player.getImperiali().Coins;
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