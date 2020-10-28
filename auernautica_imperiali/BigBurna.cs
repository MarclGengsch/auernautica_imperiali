namespace auernautica_imperiali {
    public class BigBurna : AOrk {
        public BigBurna(int x, int y, int z) : base(new Point(x, y, z), 3, 3, 2, 3, 7, 4, 4, 4, 22) {
            OrkList.Add(this);
        }
    }
}