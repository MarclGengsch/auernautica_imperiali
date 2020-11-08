using System;
using System.Collections.Generic;

namespace auernautica_imperiali {
    public class AirCraftFactory {        //unsure aber ich glaub die tests passen
        private AirCraftFactory()
        {
        }

        private static AirCraftFactory instance = new AirCraftFactory();

        public static AirCraftFactory GetInstance()
        {
            return instance;
        }

        public void MakeAircraft(int x, int y, int z, EAirCraftType type)
        {
            AUnit unit;
            switch (type)
            {
                case EAirCraftType.BIGBURNA:
                    unit = new AOrk(new Point(x, y, z), 3, 3, 2, 3, 7, 4, 4, 4, 22);
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.QUADBIGSHOOTAS, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.TURRETBIGSHOOTAS, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.TAILGUN, unit));
                    break;
                case EAirCraftType.VULTURE:
                    unit = new AOrk(new Point(x, y, z), 2, 3, 2, 3, 8, 5, 3, 4, 23);
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.QUADBIGSHOOTAS, unit));
                    break;
                case EAirCraftType.GROTBOMMER:
                    unit = new AOrk(new Point(x, y, z), 6, 2, 1, 2, 4, 3, 5, 4, 28);
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.QUADBIGSHOOTAS, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.PORTTURRET, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.STARBOARDTURRET, unit));
                    break;
                case EAirCraftType.BLUEDEVIL:
                    unit = new AImperiali(new Point(x, y, z), 5, 2, 1, 2, 5, 3, 3, 5, 26);
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.LASCANNON, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.DORSALTURRET, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.REARTURRET, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.BOMBBAY, unit));
                    break;
                case EAirCraftType.HELLION:
                    unit = new AImperiali(new Point(x, y, z), 2, 2, 3, 2, 8, 7, 2, 5, 26);
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.TWINMULITLASERS, unit));
                    break;
                case EAirCraftType.EXECUTIONER:
                    unit = new AImperiali(new Point(x, y, z), 3, 2, 2, 2, 7, 6, 3, 5, 23);
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.QUADAUTOCANNON, unit));
                    unit.AddWeapon(WeaponFactory.GetInstance().MakeWeapon(EWeaponType.TWINLASCANNON, unit));
                    break;
                default:
                    throw new ArgumentException();
            }
            if (unit.JoinArmy())
                Logger.GetInstance().Info("Success");
            else
                Logger.GetInstance().Info("Error");
        }
    }
}