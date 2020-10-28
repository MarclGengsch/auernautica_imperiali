namespace auernautica_imperiali {
    public interface ICommand {
        protected void IsPlaneDestroyed();

        protected bool IsSpin(); 

        protected HandlingTest(); //wenn Handlingtest failed, gleiche Ebene mit Flugzeug aus eigenem Team
    }
}