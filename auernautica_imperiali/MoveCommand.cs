namespace auernautica_imperiali {
    public class MoveCommand : ICommand {
        private AUnit _ship;
        private Point _target;
        private int _throttle;

        public MoveCommand(AUnit ship, Point target, int throttle) {
            _ship = ship;
            _target = target;
            _throttle = throttle;
        }

        public bool Execute() {
            _ship.MoveBehaviour.Move(_target, _throttle);
            return true;
        }
    }
}