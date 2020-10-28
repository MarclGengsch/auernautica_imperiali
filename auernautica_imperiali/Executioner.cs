namespace auernautica_imperiali {
    public class Executioner : AImperiali {
        public Executioner(int x, int y, int z) : base(new Point(x,y,z), 3, 2, 2, 2, 7, 6, 3, 5, 23) {
            ImperialiList.Add(this);
        }
    }
}