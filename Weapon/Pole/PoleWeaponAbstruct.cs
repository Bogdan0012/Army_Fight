// namespace Weapon{
//     using Soldiers;
//    public class PoleWeaponAbstruct : IWeapon{
//         public int HP_Level { get; private set; }
//         public int Damage { get; private set; }
//         public int DistantionOfHit { get; private set; }
       
//         protected PoleWeaponAbstruct(int damage, int distantion)
//         {
//             this.HP_Level= 100;
//             this.Damage = damage;
//             this.DistantionOfHit = distantion;
//         }
//         public int Hit(Soldier owner,Soldier enemy){
//              owner.Defend(enemy);
//              return --this.HP_Level;
//         }
//     }
// }