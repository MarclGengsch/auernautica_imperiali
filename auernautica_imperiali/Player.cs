namespace auernautica_imperiali {
    public class Player {            //unittest fertig
        private int _coins;
        private int _points;

        public int Coins
        {
            get => _coins;
            set => _coins = value;
        }

        public int Points
        {
            get => _points;
            set => _points = value;
        }

        private Player()
        {
            _coins = 150;
            _points = 0;
        }
        private static Player imperialiPlayer = new Player();
        private static Player orkPlayer = new Player();

        public static Player getImperiali()
        {
            return imperialiPlayer;
        }

        public static Player getOrk()
        {
            return orkPlayer;
        }
        
    }
}