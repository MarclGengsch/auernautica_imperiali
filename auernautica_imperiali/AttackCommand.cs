namespace auernautica_imperiali {
    public class AttackCommand : ICommand {
        private AUnit _ship;
        private AUnit _enemy;

        public AttackCommand(AUnit ship, AUnit enemy) {
            _ship = ship;
            _enemy = enemy;
        }

        public bool Execute() { //fertig machen!!
            _ship.Attack(_enemy);
            return true;
        }
    }
}