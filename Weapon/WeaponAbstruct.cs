namespace Weapon{
    using Soldiers;
   public class WeaponAbstruct : IWeapon{
        public int HP_Level { get; private set; }
       
        public int Damage { get; private set; }

        public int DistantionOfHit { get; private set; }

        public int Coefficient { get; set; }
        public Projectile Projectil { get; set;}

        
       
        protected WeaponAbstruct(int distantion, int coefficient, Projectile projectile) //c-tor for distant
        {
            this.HP_Level= 100;
            this.DistantionOfHit = distantion;
            this.Coefficient = coefficient;
            this.Projectil = projectile;
            this.Damage = coefficient * Projectil.Weight;
        }
        protected WeaponAbstruct(int damage) //c-tor for melee
        {
            this.HP_Level= 100;
            this.Damage = damage;
        }
        protected WeaponAbstruct(int damage, int distantion) //c-tor for pole
        {
            this.HP_Level= 100;
            this.Damage = damage;
            this.DistantionOfHit = distantion;
        }
        public int Hit(Soldier owner,Soldier enemy ){
            owner?.Defend(enemy);
            return --this.HP_Level;
        }

    }
}