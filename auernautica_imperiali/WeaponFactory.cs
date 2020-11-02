namespace auernautica_imperiali {
    public class WeaponFactory {
        private static WeaponFactory _instance = new WeaponFactory();

        private WeaponFactory() {
            
        }

        public static WeaponFactory GetInstance() {
            return _instance;
        }

        public Weapon MakeWeapon(EWeaponType type) {
            return new Weapon();
        }
    }
}