using System.Collections.Generic;

namespace auernautica_imperiali {
    public class GameEngine {
        private static List<AOrk> _orkList = new List<AOrk>();
        private static List<AImperiali> _imperialiList = new List<AImperiali>();

        public static List<AOrk> OrkList {
            get => _orkList;
            set => _orkList = value;
        }

        public static List<AImperiali> ImperialiList {
            get => _imperialiList;
            set => _imperialiList = value;
        }

    }
}