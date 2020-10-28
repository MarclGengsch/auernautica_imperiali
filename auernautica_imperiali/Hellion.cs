namespace auernautica_imperiali {
    public class Hellion : AImperiali {
        public Hellion(int x, int y, int z) : base(new Point(x,y,z), 2, 2, 3, 2, 8, 7, 2, 5, 26) {
            ImperialiList.Add(this);
        }
    }
}