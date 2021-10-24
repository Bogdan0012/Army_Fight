// namespace Weapon{
//     using Soldiers;
//    public class DistantWeaponAbstruct : IWeapon{
//         public int HP_Level { get; private set; }
       
//         public int Damage { get; private set; }

//         public int DistantionOfHit { get; private set; }

//         public int Coefficient { get; set; }
//         public Projectile Projectil { get; set;}

        
       
//         protected DistantWeaponAbstruct(int distantion, int coefficient, Projectile projectile)
//         {
//             this.HP_Level= 100;
//             this.DistantionOfHit = distantion;
//             this.Coefficient = coefficient;
//             this.Projectil = projectile;
//             this.Damage = coefficient * Projectil.Weight;
//         }
//         public int Hit(Soldier owner,Soldier enemy ){
//             owner.Defend(enemy);
//             return --this.HP_Level;
//         }

//     }
// }