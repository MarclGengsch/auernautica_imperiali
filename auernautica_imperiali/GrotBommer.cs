namespace auernautica_imperiali {
    public class GrotBommer : AOrk {
        public GrotBommer(int x, int y, int z) : base(new Point(x, y, z), 6, 2, 1, 2, 4, 3, 5, 4, 28) {
            OrkList.Add(this);
        }
    }
}