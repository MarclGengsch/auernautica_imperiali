using System;
using System.Collections.Generic;

namespace auernautica_imperiali {
    public class WeaponFactory {
        private static WeaponFactory _instance = new WeaponFactory();

        private WeaponFactory() {
            
        }

        public static WeaponFactory GetInstance() {
            return _instance;
        }

        public Weapon MakeWeapon(EWeaponType type) {
            Weapon weapon;
            switch (type)
            {
                case EWeaponType.QUADBIGSHOOTAS:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.FRONT}, new List<int>() {8,4,0}, 5);
                    break;
                case EWeaponType.TURRETBIGSHOOTAS:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.REAR, EFireArc.RIGHT, EFireArc.LEFT}, new List<int>() {3,1,0}, 5);
                    break;
                case EWeaponType.TAILGUN:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.REAR}, new List<int>() {1,0,0}, 6);
                    break;
                case EWeaponType.PORTTURRET:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.LEFT}, new List<int>() {2,1,0}, 5);
                    break;
                case EWeaponType.STARBOARDTURRET:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.RIGHT}, new List<int>() {2,1,0}, 5);
                    break;
                case EWeaponType.LASCANNON:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.FRONT}, new List<int>() {0,2,1}, 2);                    
                    break;
                case EWeaponType.DORSALTURRET:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.FRONT, EFireArc.LEFT, EFireArc.REAR, EFireArc.RIGHT}, new List<int>() {3,2,0}, 5);                    
                    break;
                case EWeaponType.REARTURRET:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.REAR}, new List<int>() {3,2,0}, 5);                   
                    break;
                case EWeaponType.BOMBBAY:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.REAR}, new List<int>() {8,0,0}, 2);                   
                    break;
                case EWeaponType.TWINMULITLASERS:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.FRONT}, new List<int>() {4,6,2}, 5);                 
                    break;
                case EWeaponType.QUADAUTOCANNON:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.FRONT}, new List<int>() {2,6,0}, 4);                
                    break;
                case EWeaponType.TWINLASCANNON:
                    weapon = new Weapon(new List<EFireArc>() {EFireArc.FRONT}, new List<int>() {0,2,1}, 2);                
                    break;
                default:
                    throw new ArgumentException();
            }

            return weapon;
        }
    }
}