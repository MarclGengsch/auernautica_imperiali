namespace auernautica_imperiali {
    public class Vulture : AOrk {
        public Vulture(int x, int y, int z) : base(new Point(x,y,z), 2, 3, 2, 3, 8, 5, 3, 4, 23) {
            OrkList.Add(this);
        }
    }
}