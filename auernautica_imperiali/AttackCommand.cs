namespace auernautica_imperiali {
    public class AttackCommand : ICommand {
        private AUnit _ship;
        private AUnit _enemy;

        public AttackCommand(AUnit ship, AUnit enemy) {
            _ship = ship;
            _enemy = enemy;
        }

        public bool Execute() {
            _ship.Attack(_enemy);
            GameEngine.GetInstance().HasWon();
            return true;
        }
    }
}