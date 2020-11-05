namespace auernautica_imperiali {
    public class MoveCommand : ICommand {
        private AUnit _ship;
        private Point _target;

        public MoveCommand(AUnit ship, Point target) {
            _ship = ship;
            _target = target;
        }

        public bool Execute() {
            _ship.MoveBehaviour.Move(_target);
            return true;
        }
    }
}