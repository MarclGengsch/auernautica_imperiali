namespace auernautica_imperiali {
    public class BlueDevil : AImperiali {
        public BlueDevil(int x, int y, int z) : base(new Point(x, y, z), 5, 2, 1, 2, 5, 3, 3, 5) {
            ImperialiList.Add(this);
        }
    }
}